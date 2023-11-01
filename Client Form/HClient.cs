using Newtonsoft.Json;
using Server_Form;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Client_Form
{
    public class HClient
    {
        public TcpClient client;
        private NetworkStream stream;
        private BinaryReader reader;
        private BinaryWriter writer;
        private int PORT = 7749;
        IPAddress serverAddress = IPAddress.Parse("127.0.0.1");
        public string username;
        public Form1 form;

        public void Connect(string username)
        {
            username = username;
            client = new TcpClient();
            client.Connect("127.0.0.1", PORT);
            writer = new BinaryWriter(client.GetStream());
            reader = new BinaryReader(client.GetStream());
            writer.Write(username);

            // Start a separate thread to receive messages from the server
            Thread receiveThread = new(ReceiveMessages);
            receiveThread.Start();
        }

        private void ReceiveMessages()
        {
            try
            {
                while (true)
                {
                    string message = reader.ReadString();
                    if (message[0] == '[')
                    {

                    List<MailMessage> listMessage = JsonConvert.DeserializeObject<List<MailMessage>>(message);
                    form.AddRow(listMessage);
                    }
                    //form.ClearTalbe();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
