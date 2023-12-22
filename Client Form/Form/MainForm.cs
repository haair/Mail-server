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
            HClient.SendRequestMailbox();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            HClient.SendRequestMailbox();
        }



        public void SetHello()
        {
            label2.Text = "Hello, " + Utils.info.fullName;
        }

        public void AddRow()
        {
            try
            {
                tbl_hop_thu_den.Invoke(new MethodInvoker(delegate
                {
                    ClearTalbe(tbl_hop_thu_den);
                    foreach (HEmail m in Utils.mailNhan)
                    {
                        tbl_hop_thu_den.Rows.Add(m.messageID, m.sender.fullName, m.subject, Utils.GetTimeAgo(m.timestamp), m.status);
                    }
                    foreach (DataGridViewRow row in tbl_hop_thu_den.Rows)
                    {
                        if ((int)row.Cells[4].Value == 0)
                        {
                            row.DefaultCellStyle.Font = new Font(Font, FontStyle.Bold);
                        }
                    }
                }
                ));

                tbl_thu_da_gui.Invoke(new MethodInvoker(delegate
                {
                    tbl_thu_da_gui.Rows.Clear();
                    foreach (HEmail m in Utils.mailGui)
                    {
                        tbl_thu_da_gui.Rows.Add(m.messageID, m.recipient.fullName, m.subject, Utils.GetTimeAgo(m.timestamp));
                    }
                }
               ));

                tbl_thung_rac.Invoke(new MethodInvoker(delegate
                {
                    tbl_thung_rac.Rows.Clear();
                    foreach (HEmail m in Utils.mailBin)
                    {
                        tbl_thung_rac.Rows.Add(m.messageID, m.sender.fullName == Utils.info.fullName ? "Tôi" : m.sender.fullName, m.recipient.fullName == Utils.info.fullName ? "Tôi" : m.recipient.fullName, m.subject, Utils.GetTimeAgo(m.timestamp));
                    }
                }
               ));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public void ClearTalbe(DataGridView dataGridView)
        {
            dataGridView.Rows.Clear();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //HClient.Disconnect();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = tbl_hop_thu_den.CurrentCell.RowIndex;
            int id = (int)tbl_hop_thu_den.Rows[index].Cells[0].Value;

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
            int id = (int)tbl_thu_da_gui.Rows[index].Cells[0].Value;

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

        private void button3_Click(object sender, EventArgs e)
        {
            DataGridView gridView;
            bool remove = false;
            var tab_index = tabControl1.SelectedIndex;
            if (tab_index == 0)
            {
                gridView = tbl_hop_thu_den;
            }
            else if (tab_index == 1)
            {
                gridView = tbl_thu_da_gui;
            }
            else
            {
                gridView = tbl_thung_rac;
                remove = true;
            }
            int row_index = gridView.CurrentCell.RowIndex;
            if (row_index < 0)
            {
                return;
            }
            int messageID = (int)gridView.Rows[row_index].Cells[0].Value;
            HMessage hMessage = new();
            hMessage.WriteInt(messageID);
            if (remove)
            {
                hMessage.id = 6;
                DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa thư này không?", "Xóa", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    HClient.SendMessage(hMessage);
                    gridView.Rows.RemoveAt(row_index);
                    return;
                }
                else if (dialogResult == DialogResult.No)
                {
                    return;
                }
            }
            hMessage.id = 5;
            HClient.SendMessage(hMessage);
            gridView.Rows.RemoveAt(row_index);
            HClient.SendRequestMailbox();
        }

        private void tbl_thung_rac_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = tbl_thung_rac.CurrentCell.RowIndex;
            int id = (int)tbl_thung_rac.Rows[index].Cells[0].Value;

            foreach (var mail in Utils.mailBin)
            {
                if (mail.messageID == id)
                {
                    var form = new ViewEmailForm(mail);
                    form.Show();
                    return;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_restore_Click(object sender, EventArgs e)
        {
            int row_sel_index = tbl_thung_rac.CurrentCell.RowIndex;
            if (row_sel_index > -1)
            {
                int id_mail_sel = (int)tbl_thung_rac.Rows[row_sel_index].Cells[0].Value;
                HMessage hMessage = new()
                {
                    id = 8
                };
                hMessage.WriteInt(id_mail_sel);
                HClient.SendMessage(hMessage);
            }
        }

        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (tabControl1.SelectedIndex == 2)
            {
                btn_restore.Enabled = true;
            }
            else if (tabControl1.SelectedIndex == 0)
            {
                button5.Enabled = true;
            }
            else
            {
                btn_restore.Enabled = false;
                button5.Enabled = false;
            }
        }

        private void tbl_hop_thu_den_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int currentMouseOverRow = tbl_hop_thu_den.HitTest(e.X, e.Y).RowIndex;

                if (currentMouseOverRow >= 0)
                {
                    //ToolStripMenuItem markIsRead = new("Đánh dấu là đã đọc");
                    //markIsRead.MouseDown += new MouseEventHandler(MarkAsRead);
                    //contextMenuStrip1.Items.Add(markIsRead);
                    contextMenuStrip1.Show(tbl_hop_thu_den, new Point(e.X, e.Y));
                }
            }
        }

        private void MarkAsRead(object sender, MouseEventArgs e)
        {
            int currentMouseOverRow = tbl_hop_thu_den.HitTest(e.X, e.Y).RowIndex;
            MessageBox.Show(currentMouseOverRow.ToString());
        }

        private void đánhDấuToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int index = tbl_hop_thu_den.CurrentCell.RowIndex;
            int id = (int)tbl_hop_thu_den.Rows[index].Cells[0].Value;
            int status = (int)tbl_hop_thu_den.Rows[index].Cells[4].Value;
            if (index > -1)
            {
                HMessage message = new()
                {
                    id = 9
                };
                message.WriteInt(id);
                message.WriteInt(status);
                HClient.SendMessage(message);
            }
        }
    }
}