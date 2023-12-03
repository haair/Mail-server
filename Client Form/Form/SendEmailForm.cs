using Client_Form.Model;

namespace Client_Form
{
    public partial class SendEmailForm : Form
    {
        public SendEmailForm()
        {
            InitializeComponent();
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
            HEmail email = new(-1, Utils.info.mailBox, Utils.info.emailAddress, txtNguoiNhan.Text, txtTieuDe.Text, txtNoiDung.Text, Utils.CurrentTimeSeconds(), 0);
            sms.AddEmail(email);
            HClient.SendMessage(sms);
        }
    }
}
