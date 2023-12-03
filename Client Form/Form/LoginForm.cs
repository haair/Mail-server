using Client_Form.Model;

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

        private void button1_Click(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            if (txt_tk_sign.Text == "" || txt_mk_sign.Text == "" || txt_mk2_sign.Text == "" || txt_email_sign.Text == "" || txt_name_sign.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }
            if (txt_mk_sign.Text != txt_mk2_sign.Text)
            {
                MessageBox.Show("Mật khẩu nhập lại không chính xác");
                return;
            }
            //string connectionString = "Data Source=HAAIR;Initial Catalog=mail_server;User ID=haair;Password=54321";

            //SqlConnection connection = new SqlConnection(connectionString);

            //try
            //{
            //    connection.Open();
            //    string tk = txt_tk_sign.Text;
            //    string mk = txt_mk_sign.Text;
            //    string name = txt_name_sign.Text;
            //    string email = txt_email_sign.Text;
            //    string sql_login = $"SELECT * FROM MailUser WHERE username = '{tk}' AND emailAddress = '{email}'";

            //    SqlCommand command = new SqlCommand(sql_login, connection);
            //    SqlDataReader reader = command.ExecuteReader();

            //    if (reader.Read())
            //    {
            //        MessageBox.Show("Tài khoản/email tồn tại");
            //        return;
            //    }
            //    reader.Close();
            //    string add_user = $"INSERT INTO MailUser(username, password, fullName, emailAddress) VALUES ('{tk}', '{mk}', '{name}', '{email}')";
            //    SqlCommand command1 = new SqlCommand(add_user, connection);
            //    int rs = command1.ExecuteNonQuery();
            //    if (rs == 1)
            //    {
            //        MessageBox.Show("Đăng ký thành công");
            //        return;
            //    }


            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}

        }
    }
}
