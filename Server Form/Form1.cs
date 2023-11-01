using System.Data.SqlClient;

namespace Server_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            HServer.Start();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void AddMessage(string message)
        {
            log_txt.Invoke((MethodInvoker)(() => log_txt.AppendText(message + "\n")));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HServer.Start();
            string connetionString;
            SqlConnection cnn;
            connetionString = @"Data Source=HAAIR;Initial Catalog=mail_server;User ID=haair;Password=54321";

            cnn = new SqlConnection(connetionString);
            cnn.Open();

            SqlCommand sqlCommand;
            SqlDataReader reader;

            string sqlstr = "SELECT * FROM MailUser";

            sqlCommand = new SqlCommand(sqlstr, cnn);
            reader = sqlCommand.ExecuteReader();

            while (reader.Read())
            {
                AddMessage(reader.GetString(1));
            }

            cnn.Close();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}