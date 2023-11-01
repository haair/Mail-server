using Server_Form;

namespace Client_Form
{
    public partial class Form1 : Form
    {
        public string username;
        public List<MailMessage> messages;
        public Form1(string username)
        {
            this.username = username;
            HClient client = new HClient();
            InitializeComponent();
            client.form = this;
            client.Connect(username);
            SetHello();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        public void SetHello()
        {
            label2.Text = "Hello, " + username;
        }

        public void AddRow(List<MailMessage> messages)
        {
            this.messages = messages;
            for (int i = 0; i < messages.Count; i++)
            {
                MailMessage m = messages[i];
                dataGridView1.Rows.Add(m.sender, m.subject, m.timestamp);
            }
            dataGridView1.Update();
            dataGridView1.Refresh();
        }

        public void ClearTalbe()
        {
            dataGridView1.Rows.Clear();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dataGridView1.CurrentRow.Index;
            MessageBox.Show("Nguoi gui: " + messages[index].sender + "\n" +
                "Tieu de: " + messages[index].subject + "\n" +
                "Noi dung: " + messages[index].body + "\n" +
                "Thoi gian: " + messages[index].timestamp
                );
        }
    }
}