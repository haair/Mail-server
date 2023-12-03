namespace Client_Form
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            button1 = new Button();
            txt_mk_login = new TextBox();
            txt_tk_login = new TextBox();
            label2 = new Label();
            label1 = new Label();
            tabPage2 = new TabPage();
            button2 = new Button();
            txt_name_sign = new TextBox();
            txt_email_sign = new TextBox();
            txt_mk2_sign = new TextBox();
            txt_mk_sign = new TextBox();
            txt_tk_sign = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Margin = new Padding(2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(640, 360);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(txt_mk_login);
            tabPage1.Controls.Add(txt_tk_login);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Margin = new Padding(2);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(2);
            tabPage1.Size = new Size(632, 327);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Đăng nhập";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(231, 178);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(135, 37);
            button1.TabIndex = 8;
            button1.Text = "Đăng nhập";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txt_mk_login
            // 
            txt_mk_login.Location = new Point(199, 125);
            txt_mk_login.Margin = new Padding(2);
            txt_mk_login.Name = "txt_mk_login";
            txt_mk_login.Size = new Size(250, 27);
            txt_mk_login.TabIndex = 7;
            // 
            // txt_tk_login
            // 
            txt_tk_login.Location = new Point(199, 78);
            txt_tk_login.Margin = new Padding(2);
            txt_tk_login.Name = "txt_tk_login";
            txt_tk_login.Size = new Size(250, 27);
            txt_tk_login.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(122, 130);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 4;
            label2.Text = "Mật khẩu";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(122, 78);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(71, 20);
            label1.TabIndex = 5;
            label1.Text = "Tài khoản";
            label1.Click += label1_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(button2);
            tabPage2.Controls.Add(txt_name_sign);
            tabPage2.Controls.Add(txt_email_sign);
            tabPage2.Controls.Add(txt_mk2_sign);
            tabPage2.Controls.Add(txt_mk_sign);
            tabPage2.Controls.Add(txt_tk_sign);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(label3);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Margin = new Padding(2);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(2);
            tabPage2.Size = new Size(632, 327);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Đăng ký";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(265, 224);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(168, 52);
            button2.TabIndex = 2;
            button2.Text = "Đăng ký";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // txt_name_sign
            // 
            txt_name_sign.Location = new Point(232, 161);
            txt_name_sign.Margin = new Padding(2);
            txt_name_sign.Name = "txt_name_sign";
            txt_name_sign.Size = new Size(252, 27);
            txt_name_sign.TabIndex = 1;
            // 
            // txt_email_sign
            // 
            txt_email_sign.Location = new Point(232, 190);
            txt_email_sign.Margin = new Padding(2);
            txt_email_sign.Name = "txt_email_sign";
            txt_email_sign.Size = new Size(252, 27);
            txt_email_sign.TabIndex = 1;
            // 
            // txt_mk2_sign
            // 
            txt_mk2_sign.Location = new Point(232, 125);
            txt_mk2_sign.Margin = new Padding(2);
            txt_mk2_sign.Name = "txt_mk2_sign";
            txt_mk2_sign.Size = new Size(252, 27);
            txt_mk2_sign.TabIndex = 1;
            // 
            // txt_mk_sign
            // 
            txt_mk_sign.Location = new Point(232, 97);
            txt_mk_sign.Margin = new Padding(2);
            txt_mk_sign.Name = "txt_mk_sign";
            txt_mk_sign.Size = new Size(252, 27);
            txt_mk_sign.TabIndex = 1;
            // 
            // txt_tk_sign
            // 
            txt_tk_sign.Location = new Point(232, 64);
            txt_tk_sign.Margin = new Padding(2);
            txt_tk_sign.Name = "txt_tk_sign";
            txt_tk_sign.Size = new Size(252, 27);
            txt_tk_sign.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(147, 161);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(73, 20);
            label7.TabIndex = 0;
            label7.Text = "Họ và tên";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(147, 190);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(46, 20);
            label6.TabIndex = 0;
            label6.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(91, 130);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(130, 20);
            label5.TabIndex = 0;
            label5.Text = "Nhập lại mật khẩu";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(147, 99);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 0;
            label4.Text = "Mật khẩu";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(147, 64);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(71, 20);
            label3.TabIndex = 0;
            label3.Text = "Tài khoản";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 360);
            Controls.Add(tabControl1);
            Margin = new Padding(2);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Start";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Button button1;
        private TextBox txt_mk_login;
        private TextBox txt_tk_login;
        private Label label2;
        private Label label1;
        private TabPage tabPage2;
        private Button button2;
        private TextBox txt_email_sign;
        private TextBox txt_mk2_sign;
        private TextBox txt_mk_sign;
        private TextBox txt_tk_sign;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox txt_name_sign;
        private Label label7;
    }
}