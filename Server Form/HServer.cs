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
        private static readonly string connectionString = "Data Source=HAAIR;Initial Catalog=mail_server;User ID=haair;Password=12345";

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
                                email.mailboxId = rs;
                                AddEMail(email);
                                HMessage hMessage1 = new() { id = 4, };
                                SendMessage(hMessage1, writer);
                                form?.AddMessage("add ok");
                                break;
                            }
                            HMessage hMessage = new() { id = -4, };
                            SendMessage(hMessage, writer);
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

                string sqlstr = $"INSERT INTO MailMessage (mailboxID, sender, recipient, subject, body, timestamp, status) VALUES ({hEmail.mailboxId}, '{hEmail.sender}', '{hEmail.recipient}', '{hEmail.subject}', '{hEmail.body}', {hEmail.timestamp}, 0)";

                sqlCommand = new SqlCommand(sqlstr, cnn);
                int rs = sqlCommand.ExecuteNonQuery();
                if (rs > 0)
                {
                    //form?.AddMessage("Insert +1");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
            SqlConnection connection = new(connectionString);
            connection.Open();
            string sql = $"SELECT * FROM MailMessage WHERE mailboxID = {mailboxID} ORDER BY timestamp DESC";
            SqlCommand command = new(sql, connection);
            SqlDataReader reader = command.ExecuteReader();
            List<HEmail> lMail = new();

            while (reader.Read())
            {
                HEmail message = new()
                {
                    messagesId = reader.GetInt32(0),
                    mailboxId = reader.GetInt32(1),
                    sender = reader.GetString(2),
                    recipient = reader.GetString(3),
                    subject = reader.GetString(4),
                    body = reader.GetString(5),
                    timestamp = reader.GetInt32(6),
                    status = reader.GetInt32(7)
                };
                lMail.Add(message);
            }
            connection.Close();
            return lMail;
        }

        public static void SendMessage(HMessage message, BinaryWriter binaryWriter)
        {
            string str = JsonConvert.SerializeObject(message);
            binaryWriter?.Write(str);
        }
    }
}
