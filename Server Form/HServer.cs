using Newtonsoft.Json;
using System.Data.SqlClient;
using System.Net;
using System.Net.Sockets;

namespace Server_Form
{
    public class HServer
    {
        private static readonly int PORT = 7749;
        private static TcpListener? listener;
        private static readonly IPAddress ip = IPAddress.Parse("127.0.0.1");
        public static MainForm? form;
        private static readonly string connectionString = "Data Source=HAAIR;Initial Catalog=mail_server;User ID=haair;Password=12345;MultipleActiveResultSets=True";

        public static void Start()
        {
            new Thread(() =>
            {
                try
                {
                    listener = new TcpListener(ip, PORT);
                    listener.Start();

                    while (true)
                    {
                        TcpClient client = listener.AcceptTcpClient();
                        new Thread(() =>
                        {
                            HandleClient(client);
                        })
                        {
                            IsBackground = true
                        }.Start();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            })
            {
                IsBackground = true
            }.Start();
        }

        private static void HandleClient(TcpClient client)
        {
            NetworkStream stream = client.GetStream();
            BinaryWriter writer = new(stream);
            BinaryReader read = new(stream);

            try
            {
                while (true)
                {
                    string come = read.ReadString();
                    HMessage? mess = JsonConvert.DeserializeObject<HMessage>(come);
                    switch (mess?.id)
                    {
                        case 0:
                            form?.AddMessage("Have connect");
                            break;
                        case 1:
                            string username = mess.listString[0];
                            if (CheckAccount(mess.ReadString(), mess.ReadString()))
                            {
                                var arr = GetInfoByUsername(username);
                                HInfo info = new HInfo(arr[0], arr[1], int.Parse(arr[2]));
                                HMessage? message = new()
                                {
                                    id = 1,
                                    info = info
                                };
                                SendMessage(message, writer);
                                form?.AddMessage(mess.listString[0] + " login successful!");
                            }
                            else
                            {
                                form?.AddMessage(mess.listString[0] + " login unsuccessful!");
                            }
                            break;
                        case 2:
                            var lMail = GetListMessageByMailboxID(mess.ReadInt());
                            HMessage? sms = new()
                            {
                                id = 2,
                                listMail = lMail
                            };
                            SendMessage(sms, writer);
                            break;
                        case 3:
                            HMessage? sms1 = new()
                            {
                                id = 3,
                            };
                            sms1.WriteString("Hello world");
                            SendMessage(sms1, writer);
                            break;
                        case 4:
                            HEmail? email = mess.listMail.First();
                            string address = email.recipient;
                            int rs = CheckEmailAddress(address);
                            if (rs != -1)
                            {
                                AddEMail(email);
                                email.mailboxID = rs;
                                AddEMail(email);
                                HMessage hMessage1 = new() { id = 4, };
                                SendMessage(hMessage1, writer);
                                form?.AddMessage("add ok");
                                break;
                            }
                            HMessage hMessage = new() { id = -4, };
                            SendMessage(hMessage, writer);
                            break;
                        case 5:
                            var messID = mess.ReadInt();
                            RemoveMailIntoBin(messID);
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                //clients.Remove(clientInfo);
                stream.Close();
                client.Close();
                form?.AddMessage("Client disconnect!");
            }
        }

        private static bool CheckAccount(string username, string password)
        {
            try
            {
                SqlConnection cnn;

                cnn = new SqlConnection(connectionString);
                cnn.Open();

                SqlCommand sqlCommand;
                SqlDataReader reader;

                string sqlstr = $"SELECT * FROM MailUser WHERE username = '{username}' AND password = '{password}'";

                sqlCommand = new SqlCommand(sqlstr, cnn);
                reader = sqlCommand.ExecuteReader();
                bool flag = reader.Read();

                if (flag)
                {
                    cnn.Close();
                    return true;
                }
                cnn.Close();
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        private static int CheckEmailAddress(string address)
        {
            SqlConnection cnn;

            cnn = new SqlConnection(connectionString);
            cnn.Open();

            SqlCommand sqlCommand;
            SqlDataReader reader;

            string sqlstr = $"SELECT b.mailBoxID FROM MailUser u INNER JOIN MailBox b ON u.userID = b.userID WHERE emailAddress = '{address}'";

            sqlCommand = new SqlCommand(sqlstr, cnn);
            reader = sqlCommand.ExecuteReader();
            bool flag = reader.Read();

            if (flag)
            {
                return reader.GetInt32(0);
            }
            cnn.Close();
            return -1;
        }

        private static void AddEMail(HEmail hEmail)
        {
            try
            {
                SqlConnection cnn;

                cnn = new SqlConnection(connectionString);
                cnn.Open();

                SqlCommand sqlCommand;
                SqlDataReader reader;
                int new_id = -1;

                string sqlstr1 = $"INSERT INTO MailMessage (mailboxID, sender, recipient, subject, body, timestamp, status) VALUES ({hEmail.mailboxID}, '{hEmail.sender}', '{hEmail.recipient}', '{hEmail.subject}', '{hEmail.body}', {hEmail.timestamp}, 0) SELECT SCOPE_IDENTITY()";

                sqlCommand = new SqlCommand(sqlstr1, cnn);
                reader = sqlCommand.ExecuteReader();

                if (reader.Read())
                {
                    new_id = (int)reader.GetDecimal(0);
                }

                var num_attachment = hEmail.attachments.Count;
                if (num_attachment > 0)
                {
                    string sqlstr2 = $"INSERT INTO Attachment (messageID, fileName) VALUES ";
                    for (int i = 0; i < num_attachment; i++)
                    {
                        if (i == num_attachment - 1)
                        {
                            sqlstr2 += $"({new_id}, '{hEmail.attachments.ElementAt(i).fileName}')";
                        }
                        else
                        {
                            sqlstr2 += $"({new_id}, '{hEmail.attachments.ElementAt(i).fileName}'), ";
                        }

                        string desPath = $"data\\{hEmail.mailboxID}\\{new_id}\\{hEmail.attachments.ElementAt(i).fileName}";
                        FileInfo fileInfo = new FileInfo(desPath);
                        fileInfo.Directory.Create();
                        File.WriteAllBytes(desPath, hEmail.attachments.ElementAt(i).data);
                    }
                    sqlCommand = new SqlCommand(sqlstr2, cnn);
                    sqlCommand.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private static void RemoveMailIntoBin(int messageID)
        {
            SqlConnection connection = new(connectionString);
            connection.Open();
            string sql = $"UPDATE MailMessage SET status = -1 WHERE messageID = {messageID}";
            SqlCommand command = new(sql, connection);
            var result = command.ExecuteNonQuery();
            if (result != 0)
            {
                form?.AddMessage("Update successfully!");
            }
        }

        private static string[] GetInfoByUsername(string username)
        {
            SqlConnection cnn;

            cnn = new SqlConnection(connectionString);
            cnn.Open();

            SqlCommand sqlCommand;
            SqlDataReader reader;
            string[] arr = new string[3];

            string sqlstr = $"SELECT u.username, u.emailAddress, b.mailboxID FROM MailUser u INNER JOIN Mailbox b ON b.userID = u.userID WHERE u.username = '{username}'";

            sqlCommand = new SqlCommand(sqlstr, cnn);
            reader = sqlCommand.ExecuteReader();
            bool flag = reader.Read();

            if (flag)
            {
                arr[0] = reader.GetString(0);
                arr[1] = reader.GetString(1);
                arr[2] = reader.GetInt32(2).ToString();
            }
            cnn.Close();
            return arr;
        }

        private static List<HEmail> GetListMessageByMailboxID(int mailboxID)
        {
            List<HEmail> lMail = new();
            try
            {
                SqlConnection connection = new(connectionString);
                connection.Open();
                string sql = $"SELECT * FROM MailMessage WHERE mailboxID = {mailboxID} ORDER BY timestamp DESC";
                SqlCommand command = new(sql, connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    var messageID = reader.GetInt32(0);
                    var mBoxID = reader.GetInt32(1);
                    var sender = reader.GetString(2);
                    var recipient = reader.GetString(3);
                    var subject = reader.GetString(4);
                    var body = reader.GetString(5);
                    var timestamp = reader.GetInt32(6);
                    var status = reader.GetInt32(7);

                    HEmail message = new()
                    {
                        messageID = messageID,
                        mailboxID = mBoxID,
                        sender = sender,
                        recipient = recipient,
                        subject = subject,
                        body = body,
                        timestamp = timestamp,
                        status = status,
                    };
                    lMail.Add(message);
                }

                var length = lMail.Count;
                for (int i = 0; i < length; i++)
                {
                    var mID = lMail[i].messageID;
                    string sql1 = $"SELECT * FROM Attachment WHERE messageID = {mID}";
                    SqlCommand command1 = new(sql1, connection);
                    SqlDataReader reader1 = command1.ExecuteReader();
                    List<HAttachment> lAttachments = new();
                    while (reader1.Read())
                    {

                        var attID = reader1.GetInt32(0);
                        var messID = reader1.GetInt32(1);
                        var name = reader1.GetString(2);
                        var data = File.ReadAllBytes($"data\\{mailboxID}\\{messID}\\{name}");
                        HAttachment attachment = new()
                        {
                            attachmentID = attID,
                            messageID = messID,
                            fileName = name,
                            data = data
                        };
                        lAttachments.Add(attachment);
                    }
                    lMail[i].attachments = lAttachments;
                }


                connection.Close();
                return lMail;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return lMail;
            }
        }

        public static void SendMessage(HMessage message, BinaryWriter binaryWriter)
        {
            string str = JsonConvert.SerializeObject(message);
            binaryWriter?.Write(str);
        }
    }
}
