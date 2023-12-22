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
        private static readonly IPAddress ip = IPAddress.Parse("26.133.94.211");
        public static MainForm? form;
        private static readonly string connectionString = "Data Source=HAAIR;Initial Catalog=mail_server;User ID=haair;Password=4869;MultipleActiveResultSets=True";

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
                            if (IsUserExist(mess.ReadString(), mess.ReadString()))
                            {
                                var arr_info = GetInfoByUsername(username);
                                HInfo info = new(arr_info[0], arr_info[1], int.Parse(arr_info[2]), arr_info[3]);
                                HMessage? message1 = new()
                                {
                                    id = 1,
                                    info = info
                                };
                                SendMessage(message1, writer);
                                form?.AddMessage(mess.listString[0] + " login successful!");
                            }
                            else
                            {
                                SendMessage(new HMessage() { id = -1 }, writer);
                                form?.AddMessage(mess.listString[0] + " login unsuccessful!");
                            }
                            break;
                        case 2:
                            var lMail = GetListMessageByMailboxID(mess.ReadInt());
                            HMessage? message2 = new()
                            {
                                id = 2,
                                listMail = lMail
                            };
                            SendMessage(message2, writer);
                            break;
                        case 3:
                            HMessage? message3 = new()
                            {
                                id = 3,
                            };
                            message3.WriteString("Hello world");
                            SendMessage(message3, writer);
                            break;
                        case 4:
                            HEmail? email = mess.listMail.First();
                            string address = email.recipient.emailAddress;
                            int rs = CheckEmailAddress(address);
                            if (rs != -1)
                            {
                                AddEmail(email);
                                email.mailboxID = rs;
                                AddEmail(email);
                                HMessage message4 = new() { id = 4, };
                                SendMessage(message4, writer);
                                form?.AddMessage("add ok");
                                break;
                            }
                            HMessage message5 = new() { id = -4, };
                            SendMessage(message5, writer);
                            break;
                        case 5:
                            var messID = mess.ReadInt();
                            SetMailStatus(messID, -1);
                            break;
                        case 6:
                            var messID1 = mess.ReadInt();
                            RemoveMessage(messID1);
                            break;
                        case 7:
                            HRegisterInfo registerInfo = mess.registerInfo;
                            HMessage message6 = new();
                            if (IsNotRegister(registerInfo.username, registerInfo.emailAddress))
                            {
                                int id = AddUser(registerInfo.username, registerInfo.password, registerInfo.fullName, registerInfo.emailAddress);
                                AddMailbox(id, registerInfo.fullName);
                                message6.id = 7;
                                HServer.SendMessage(message6, writer);
                                break;
                            }
                            message6.id = -7;
                            HServer.SendMessage(message6, writer);
                            break;
                        case 8:
                            var messID2 = mess.ReadInt();
                            SetMailStatus(messID2, 0);
                            SendMessage(new HMessage()
                            {
                                id = 8
                            }, writer);
                            break;
                        case 9:
                            var messID3 = mess.ReadInt();
                            var status = mess.ReadInt();
                            if (status == 0)
                            {
                                SetMailStatus(messID3, 1);
                            }
                            else
                            {
                                SetMailStatus(messID3, 0);
                            }
                            SendMessage(new HMessage()
                            {
                                id = 9
                            }, writer);
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                stream.Close();
                client.Close();
                form?.AddMessage("Client disconnect!");
            }
        }

        private static int AddUser(string username, string password, string fullName, string emailAddress)
        {
            try
            {
                SqlConnection cnn;
                int new_id;

                cnn = new SqlConnection(connectionString);
                cnn.Open();

                SqlCommand sqlCommand;

                string sqlstr1 = $"INSERT INTO MailUser (username, password, fullName, emailAddress) VALUES ('{username}', '{password}', '{fullName}', '{emailAddress}') SELECT SCOPE_IDENTITY()";

                sqlCommand = new SqlCommand(sqlstr1, cnn);
                var rs = sqlCommand.ExecuteReader();

                if (rs.Read())
                {
                    new_id = (int)rs.GetDecimal(0);
                    form?.AddMessage("Add user ok!");
                    return new_id;
                }
                return -1;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return -1;
            }
        }

        private static void AddMailbox(int userID, string fullName)
        {
            try
            {
                SqlConnection cnn;


                cnn = new SqlConnection(connectionString);
                cnn.Open();
                SqlCommand sqlCommand;
                string sqlstr1 = $"INSERT INTO Mailbox (userID, mailboxName) VALUES ({userID}, '{fullName}')";

                sqlCommand = new SqlCommand(sqlstr1, cnn);
                int rs = sqlCommand.ExecuteNonQuery();
                if (rs == 1)
                {
                    form?.AddMessage("Add mailbox ok!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private static bool IsNotRegister(string username, string emailAddress)
        {
            try
            {
                SqlConnection cnn;

                cnn = new SqlConnection(connectionString);
                cnn.Open();

                SqlCommand sqlCommand;
                SqlDataReader reader;

                string sqlstr = $"SELECT * FROM MailUser WHERE username = '{username}' OR emailAddress = '{emailAddress}'";

                sqlCommand = new SqlCommand(sqlstr, cnn);
                reader = sqlCommand.ExecuteReader();
                bool flag = reader.Read();

                if (flag)
                {
                    cnn.Close();
                    return false;
                }
                cnn.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return true;
            }
        }

        private static bool IsUserExist(string username, string password)
        {
            try
            {
                SqlConnection cnn;

                cnn = new SqlConnection(connectionString);
                cnn.Open();

                SqlCommand sqlCommand;
                SqlDataReader reader;

                string sqlstr = $"SELECT * FROM MailUser WHERE username = '{username}' AND password = '{password}' OR emailAddress = '{username}' AND password = '{password}'";

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

        private static void AddEmail(HEmail hEmail)
        {
            try
            {
                SqlConnection cnn;

                cnn = new SqlConnection(connectionString);
                cnn.Open();

                SqlCommand sqlCommand;
                SqlDataReader reader;
                int new_id = -1;

                string sqlstr1 = $"INSERT INTO MailMessage (mailboxID, sender, recipient, subject, body, timestamp, status) VALUES ({hEmail.mailboxID}, '{hEmail.sender.emailAddress}', '{hEmail.recipient.emailAddress}', '{hEmail.subject}', '{hEmail.body}', {hEmail.timestamp}, 0) SELECT SCOPE_IDENTITY()";

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
                            sqlstr2 += $"({new_id}, N'{hEmail.attachments.ElementAt(i).fileName}')";
                        }
                        else
                        {
                            sqlstr2 += $"({new_id}, N'{hEmail.attachments.ElementAt(i).fileName}'), ";
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

        private static void SetMailStatus(int messageID, int status)
        {
            SqlConnection connection = new(connectionString);
            connection.Open();
            string sql = $"UPDATE MailMessage SET status = {status} WHERE messageID = {messageID}";
            SqlCommand command = new(sql, connection);
            var result = command.ExecuteNonQuery();
            if (result != 0)
            {
                form?.AddMessage("Update successfully!");
            }
        }

        private static void RemoveMessage(int messageID)
        {
            SqlConnection connection = new(connectionString);
            connection.Open();
            string sql = $"DELETE FROM MailMessage WHERE messageID = {messageID}";
            SqlCommand command = new(sql, connection);
            var result = command.ExecuteNonQuery();
            if (result != 0)
            {
                form?.AddMessage("Delete successfully!");
            }
        }

        private static string[]? GetInfoByUsername(string username)
        {
            try
            {
                SqlConnection cnn;

                cnn = new SqlConnection(connectionString);
                cnn.Open();

                SqlCommand sqlCommand;
                SqlDataReader reader;
                string[] arr = new string[4];

                string sqlstr = $"SELECT u.username, u.emailAddress, b.mailboxID, u.fullName FROM MailUser u INNER JOIN Mailbox b ON b.userID = u.userID WHERE u.username = '{username}' OR u.emailAddress = '{username}'";

                sqlCommand = new SqlCommand(sqlstr, cnn);
                reader = sqlCommand.ExecuteReader();
                bool flag = reader.Read();

                if (flag)
                {
                    arr[0] = reader.GetString(0);
                    arr[1] = reader.GetString(1);
                    arr[2] = reader.GetInt32(2).ToString();
                    arr[3] = reader.GetString(3);
                }
                cnn.Close();
                return arr;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
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
                    HEmail message = new();

                    var messageID = reader.GetInt32(0);
                    var mBoxID = reader.GetInt32(1);
                    var sender = reader.GetString(2);

                    string sql1 = $"SELECT fullName FROM MailUser WHERE emailAddress = '{sender}'";
                    SqlCommand command1 = new(sql1, connection);
                    SqlDataReader reader1 = command1.ExecuteReader();
                    if (reader1.Read())
                    {
                        message.sender = new HSender(reader1.GetString(0), sender);
                    }
                    reader1.Close();

                    var recipient = reader.GetString(3);
                    string sql2 = $"SELECT fullName FROM MailUser WHERE emailAddress = '{recipient}'";
                    SqlCommand command2 = new(sql2, connection);
                    SqlDataReader reader2 = command2.ExecuteReader();
                    if (reader2.Read())
                    {
                        message.recipient = new HRecipient(reader2.GetString(0), recipient);
                    }
                    reader2.Close();
                    var subject = reader.GetString(4);
                    var body = reader.GetString(5);
                    var timestamp = reader.GetInt32(6);
                    var status = reader.GetInt32(7);

                    message.messageID = messageID;
                    message.mailboxID = mailboxID;
                    message.subject = subject;
                    message.body = body;
                    message.timestamp = timestamp;
                    message.status = status;
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
