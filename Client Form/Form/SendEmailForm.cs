using Client_Form.Model;

namespace Client_Form
{
    public partial class SendEmailForm : Form
    {
        public SendEmailForm()
        {
            InitializeComponent();
            Utils.LoadListRecentContact();
            AddRecentContact();
        }

        public void AddRecentContact()
        {
            if (Utils.recentContact == null)
            {
                return;
            }
            try
            {
                foreach (string str in Utils.recentContact)
                {
                    txtNguoiNhan.Items.Add(str);
                }
            }
            catch { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNguoiNhan.Text) || string.IsNullOrEmpty(txtNoiDung.Text) || string.IsNullOrEmpty(txtTieuDe.Text))
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin");
                return;
            }

            HMessage sms = new()
            {
                id = 4,
            };
            List<HAttachment> attachments = new();
            if (table_attachment.Rows.Count > 0)
            {
                for (int i = 0; i < table_attachment.Rows.Count; i++)
                {
                    HAttachment attachment = new()
                    {
                        fileName = (string)table_attachment.Rows[i].Cells[0].Value,
                        data = File.ReadAllBytes((string)table_attachment.Rows[i].Cells[1].Value)
                    };

                    attachments.Add(attachment);
                }
            }
            HEmail email = new(-1, Utils.info.mailBox, new HSender(string.Empty, Utils.info.emailAddress), new HRecipient(string.Empty, txtNguoiNhan.Text), txtTieuDe.Text, txtNoiDung.Text, Utils.CurrentTimeSeconds(), 0, attachments);
            sms.AddEmail(email);
            HClient.SendMessage(sms);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Thread STAThread = new(delegate ()
                {
                    OpenFileDialog openFileDialog = new()
                    {
                        Filter = "All files(*.*)|*.*|All files(*.*)|*.*",
                        Title = "Browse Image",
                        InitialDirectory = "C:\\Users\\%username%\\",
                        //openFileDialog.FilterIndex = 100;
                        //openFileDialog.RestoreDirectory = true;
                        Multiselect = true
                    };

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        Thread thread = new(() =>
                        {
                            var filenames = openFileDialog.SafeFileNames;
                            var paths = openFileDialog.FileNames;
                            if (filenames.Length > 0)
                            {

                                lb_tep_dinh_kem.Invoke(new MethodInvoker(delegate
                                {
                                    lb_tep_dinh_kem.Visible = true;
                                }));
                                table_attachment.Invoke(new MethodInvoker(delegate
                                {
                                    table_attachment.Visible = true;
                                }
                                ));
                            }
                            for (int i = 0; i < filenames.Length; i++)
                            {
                                AddRowTableSafe(filenames[i], paths[i]);
                            }
                        })
                        {
                            IsBackground = true
                        };
                        thread.Start();
                    }
                });
                STAThread.SetApartmentState(ApartmentState.STA);
                STAThread.Start();
                STAThread.Join();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void AddRowTableSafe(string filename, string path)
        {
            if (table_attachment.InvokeRequired)
            {
                Action safeAction = delegate { AddRowTableSafe(filename, path); };
                table_attachment.Invoke(safeAction);
            }
            else
            {
                table_attachment.Rows.Add(new string[] { filename, path, "Xóa" });
            }
        }

        private void table_attachment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row_index = table_attachment.CurrentCell.RowIndex;
            if (table_attachment.CurrentCell.ColumnIndex == 2)
            {
                table_attachment.Rows.RemoveAt(row_index);
            }
        }
    }
}