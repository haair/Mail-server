using Client_Form.Model;

namespace Client_Form
{
    public partial class ViewEmailForm : Form
    {
        private HEmail _mail;
        public ViewEmailForm(HEmail mail)
        {
            InitializeComponent();
            _mail = mail;
            Text = mail.subject;
            label_from.Text = $"{mail.sender.fullName} ({mail.sender.emailAddress})";
            txtSubject.Text = mail.subject;
            txtTime.Text = "Thời gian: " + Utils.GetTimeAgo1(mail.timestamp) + " (" + Utils.GetTimeAgo2(mail.timestamp) + ")";
            txtContent.Text = mail.body;

            if (mail.attachments.Count == 0)
            {
                lb_tep_dinh_kem.Visible = false;
                tbl_tep_dinh_kem.Visible = false;

                return;
            }
            var num_attachment = mail.attachments.Count;

            try
            {
                new Thread(delegate ()
                {
                    for (int i = 0; i < num_attachment; i++)
                    {
                        tbl_tep_dinh_kem.Rows.Add(mail.attachments.ElementAt(i).attachmentID, mail.attachments.ElementAt(i).fileName, "Tải xuống");
                    }
                })
                {
                    IsBackground = true
                }.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private HAttachment GetAttachmentByID(int attachmentID)
        {
            for (int i = 0; i < _mail.attachments.Count; i++)
            {
                if (_mail.attachments[i].attachmentID == attachmentID)
                {
                    return _mail.attachments[i];
                }
            }
            return null;
        }

        private void tbl_tep_dinh_kem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = tbl_tep_dinh_kem.CurrentCell.RowIndex;
            int id = (int)tbl_tep_dinh_kem.Rows[index].Cells[0].Value;
            var att = GetAttachmentByID(id);
            if (index != -1)
            {
                if (tbl_tep_dinh_kem.CurrentCell.ColumnIndex == 2)
                {
                    Thread t = new(() =>
                    {
                        using FolderBrowserDialog folderDialog = new();
                        DialogResult result = folderDialog.ShowDialog();

                        if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderDialog.SelectedPath))
                        {
                            string selectedFolder = folderDialog.SelectedPath;
                            File.WriteAllBytes(selectedFolder + $"\\{att.fileName}", att.data);
                            MessageBox.Show("Tải xuống thành công", "Tải xuống", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                        }
                    });

                    t.SetApartmentState(ApartmentState.STA);
                    t.Start();
                    t.Join();
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
