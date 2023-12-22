using Client_Form.Model;
using System.Net.Mail;
using System.Text.RegularExpressions;

namespace Client_Form
{
    public partial class LoginForm : Form
    {

        public LoginForm()
        {
            InitializeComponent();
            HClient client = new HClient();
            Utils.loginForm = this;
            HClient.Connect();
            HClient.SendMessage(new HMessage()
            {
                id = 0,
            });
            Utils.client = client;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void RequestLogin()
        {
            if (txt_tk_login.Text == "" || txt_mk_login.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }

            try
            {
                string tk = txt_tk_login.Text;
                string mk = txt_mk_login.Text;

                HMessage hMessage = new()
                {
                    id = 1
                };
                hMessage.WriteString(tk);
                hMessage.WriteString(mk);
                HClient.SendMessage(hMessage);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "xxx");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RequestLogin();
        }

        private bool IsValidPassword(string password)
        {
            Regex validateGuidRegex = new("^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$");
            if (validateGuidRegex.IsMatch(password))
            {
                return true;
            }

            return false;
        }

        private bool IsValidUsername(string username)
        {
            var regexItem = new Regex("^[^0-9\\W][\\w]*$");

            if (regexItem.IsMatch(username))
            {
                return true;
            }

            return false;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            string username = txt_tk_sign.Text;
            string password = txt_mk_sign.Text;
            string password2 = txt_mk2_sign.Text;
            string fullName = txt_name_sign.Text;
            string emailAddress = txt_email_sign.Text;

            if (username == "" || password == "" || password2 == "" || fullName == "" || emailAddress == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }

            if (!IsValidUsername(username))
            {
                MessageBox.Show("Tài khoản không được bắt đầu bằng số\nvà\nkhông chứa ký tự đặc biệt");
                return;
            }

            if (password != password2)
            {
                MessageBox.Show("Mật khẩu xác nhận không chính xác");
                return;
            }

            if (!IsValidPassword(password))
            {
                MessageBox.Show("Mật khẩu phải có:\nĐộ dài tối thiểu 8 ký tự\nÍt nhất một chữ cái viết hoa\nÍt nhất một chữ cái viết thường\nÍt nhất một chữ số\nÍt nhất một ký tự đặc biệt");
                return;
            }

            try
            {
                _ = new MailAddress(emailAddress);

            }
            catch (FormatException)
            {
                MessageBox.Show("Địa chỉ email không hợp lệ");
                return;
            }

            HRegisterInfo ri = new(username, password, fullName, emailAddress);
            HMessage sms = new()
            {
                id = 7,
                registerInfo = ri
            };
            HClient.SendMessage(sms);
        }

        private void txt_mk_login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                RequestLogin();
            }
        }

        private void ClearRegister()
        {
            txt_tk_sign.Text = string.Empty;
            txt_mk_sign.Text = string.Empty;
            txt_mk2_sign.Text = string.Empty;
            txt_name_sign.Text = string.Empty;
            txt_email_sign.Text = string.Empty;
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            HClient.Disconnect();
        }
    }
}

