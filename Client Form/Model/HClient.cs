using Newtonsoft.Json;
using System.Net.Sockets;

namespace Client_Form.Model
{
    public class HClient
    {
        public static TcpClient? client;
        public static BinaryReader? reader;
        public static BinaryWriter? writer;
        private static readonly int PORT = 7749;
        private static readonly string HOTNAME = "26.133.94.211";

        public static void Connect()
        {
            try
            {
                client = new TcpClient();
                client.Connect(HOTNAME, PORT);
                writer = new BinaryWriter(client.GetStream());
                reader = new BinaryReader(client.GetStream());

                Thread receiveThread = new(ReceiveMessages);
                receiveThread.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void Disconnect()
        {
            reader?.Close();
            writer?.Close();
            client?.Close();
        }

        public static void SendMessage(HMessage message)
        {
            try
            {
                string msg = JsonConvert.SerializeObject(message);
                writer?.Write(msg);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void ReceiveMessages()
        {
            try
            {
                while (true)
                {
                    string come = reader.ReadString();
                    HMessage? sms = JsonConvert.DeserializeObject<HMessage>(come);
                    switch (sms?.id)
                    {
                        case -1:
                            MessageBox.Show("Tên người dùng/email/mật khẩu không chính xác");
                            break;
                        case 1:
                            Utils.info = sms.info;
                            MainForm mainf = new();
                            mainf.ShowDialog();
                            break;
                        case 2:
                            Utils.allEmail.Clear();
                            Utils.allEmail = sms.listMail;
                            Utils.mailGui.Clear();
                            Utils.mailNhan.Clear();
                            Utils.mailBin.Clear();

                            foreach (var email in Utils.allEmail)
                            {
                                if (email.sender == Utils.info.emailAddress && email.status == 0)
                                {
                                    Utils.mailGui.Add(email);
                                }
                                else if (email.sender != Utils.info.emailAddress && email.status == 0)
                                {
                                    Utils.mailNhan.Add(email);
                                }
                                else
                                {
                                    Utils.mailBin.Add(email);
                                }
                            }
                            Utils.mainForm.AddRow();
                            break;
                        case 3:
                            MessageBox.Show(sms.ReadString());
                            break;
                        case 4:
                            MessageBox.Show("Gửi email thành công");
                            break;
                        case -4:
                            MessageBox.Show("Địa chỉ email không chính xác");
                            break;
                        case -7:
                            MessageBox.Show("Tài khoản hoặc địa chỉ email tồn tại!");
                            break;
                        case 7:
                            MessageBox.Show("Đăng ký thành công!");
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }
    }
}
