using Newtonsoft.Json;
using System.Data.SqlClient;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Server_Form
{
    public class HServer
    {
        public class ClientInfo
        {
            public TcpClient Client { get; set; }
            public string Username { get; set; }
        }

        private static readonly int PORT = 7749;
        private static TcpListener? listener;
        private static IPAddress ip = IPAddress.Parse("127.0.0.1");
        private static List<ClientInfo>? clients;
        public static Form1? form;
        private static readonly string connectionString = "Data Source=HAAIR;Initial Catalog=mail_server;User ID=haair;Password=54321";

        public static void Start()
        {
            new Thread(() =>
            {
                try
                {
                    listener = new TcpListener(ip, PORT);
                    clients = new List<ClientInfo>();
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
            BinaryWriter writer = new BinaryWriter(client.GetStream());
            string username = GetUsername(stream);

            byte[] buffer = new byte[1024];
            int bytesRead;

            ClientInfo clientInfo = new ClientInfo { Client = client, Username = username };
            clients.Add(clientInfo);
            form.AddMessage(username + " đã đăng nhập");
            SendList(writer, username);

            try
            {
                while (true)
                {
                    bytesRead = stream.Read(buffer, 0, buffer.Length);
                    string message = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                clients.Remove(clientInfo);
                stream.Close();
                client.Close();
            }
        }

        private static string GetUsername(NetworkStream stream)
        {
            byte[] buffer = new byte[1024];
            int bytesRead = stream.Read(buffer, 0, buffer.Length);
            string username = Encoding.UTF8.GetString(buffer, 0, bytesRead).Trim();
            return username;
        }

        private static List<MailMessage> GetListMessageByUsername(String username)
        {
            SqlConnection connection = new(connectionString);
            connection.Open();
            string sql = $"SELECT m.messageID, m.mailboxID, m.sender, m.recipient, m.subject, m.body, m.timestamp, m.status FROM MailUser u INNER JOIN Mailbox b ON u.userID = b.userID INNER JOIN MailMessage m ON b.mailboxID = m.mailboxID WHERE b.mailboxID = 11";
            SqlCommand command = new(sql, connection);
            SqlDataReader reader = command.ExecuteReader();
            List<MailMessage> messages = new List<MailMessage>();
            while (reader.Read())
            {
                MailMessage message = new()
                {
                    messageID = reader.GetInt32(0),
                    mailboxID = reader.GetInt32(1),
                    sender = reader.GetString(2),
                    recipient = reader.GetString(3),
                    subject = reader.GetString(4),
                    body = reader.GetString(5),
                    timestamp = reader.GetInt32(6),
                    status = reader.GetInt32(7)
                };
                messages.Add(message);
            }
            connection.Close();
            return messages;
        }

        private static void SendList(BinaryWriter stream, string username)
        {
            string json = JsonConvert.SerializeObject(GetListMessageByUsername(username));
            stream.Write(json);
        }
    }
}
