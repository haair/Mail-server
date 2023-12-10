using Client_Form.Model;

namespace Client_Form
{
    public partial class MainForm : Form
    {
        public List<HEmail>? listEmail;
        public MainForm()
        {
            InitializeComponent();
            Utils.mainForm = this;
            SetHello();
            HClient.Connect();
            SendRequestMailbox();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            SendRequestMailbox();
        }

        private void SendRequestMailbox()
        {
            try
            {
                HMessage message = new()
                {
                    id = 2
                };
                message.WriteInt(Utils.info.mailBox);
                HClient.SendMessage(message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void SetHello()
        {
            label2.Text = "Hello, " + Utils.info.username;
        }

        public void AddRow()
        {
            try
            {
                tbl_hop_thu_den.Invoke(new MethodInvoker(delegate
                {
                    tbl_hop_thu_den.Rows.Clear();
                    tbl_thu_da_gui.Rows.Clear();
                    foreach (HEmail m in Utils.mailNhan)
                    {
                        tbl_hop_thu_den.Rows.Add(m.messageID, m.sender, m.subject, Utils.GetTimeAgo(m.timestamp));
                    }
                    foreach (HEmail m in Utils.mailGui)
                    {
                        tbl_thu_da_gui.Rows.Add(m.messageID, m.recipient, m.subject, Utils.GetTimeAgo(m.timestamp));
                    }
                }
                ));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public void ClearTalbe()
        {
            tbl_hop_thu_den.Rows.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            HClient.Disconnect();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = tbl_hop_thu_den.CurrentCell.RowIndex;
            int id = int.Parse(tbl_hop_thu_den.Rows[index].Cells[0].Value.ToString());

            foreach (var mail in Utils.mailNhan)
            {
                if (mail.messageID == id)
                {
                    var form = new ViewEmailForm(mail);
                    form.Show();
                    return;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form = new SendEmailForm();
            form.Show();
        }

        private void tbl_thu_da_gui_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = tbl_thu_da_gui.CurrentCell.RowIndex;
            int id = int.Parse(tbl_thu_da_gui.Rows[index].Cells[0].Value.ToString());

            foreach (var mail in Utils.mailGui)
            {
                if (mail.messageID == id)
                {
                    var form = new ViewEmailForm(mail);
                    form.Show();
                    return;
                }
            }
        }
    }
}