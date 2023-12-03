using Client_Form.Model;

namespace Client_Form
{
    public partial class ViewEmailForm : Form
    {
        public ViewEmailForm(HEmail mail)
        {
            InitializeComponent();
            Text = mail.subject;
            txtSender.Text = "Gửi từ: " + mail.sender;
            txtSubject.Text = mail.subject;
            txtTime.Text = "Thời gian: " + Utils.GetTimeAgo1(mail.timestamp) + " (" + Utils.GetTimeAgo2(mail.timestamp) + ")";
            txtContent.Text = mail.body;
        }
    }
}
