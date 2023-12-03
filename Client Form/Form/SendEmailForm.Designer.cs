namespace Client_Form
{
    partial class SendEmailForm
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
            label1 = new Label();
            txtNguoiNhan = new TextBox();
            label2 = new Label();
            txtTieuDe = new TextBox();
            label3 = new Label();
            txtNoiDung = new RichTextBox();
            button1 = new Button();
            button2 = new Button();
            listView1 = new ListView();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(87, 20);
            label1.TabIndex = 0;
            label1.Text = "Người nhận";
            // 
            // txtNguoiNhan
            // 
            txtNguoiNhan.Location = new Point(12, 32);
            txtNguoiNhan.Margin = new Padding(3, 3, 20, 3);
            txtNguoiNhan.Name = "txtNguoiNhan";
            txtNguoiNhan.Size = new Size(616, 27);
            txtNguoiNhan.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 62);
            label2.Name = "label2";
            label2.Size = new Size(58, 20);
            label2.TabIndex = 0;
            label2.Text = "Tiêu đề";
            // 
            // txtTieuDe
            // 
            txtTieuDe.Location = new Point(12, 85);
            txtTieuDe.Margin = new Padding(3, 3, 20, 3);
            txtTieuDe.Name = "txtTieuDe";
            txtTieuDe.Size = new Size(616, 27);
            txtTieuDe.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 115);
            label3.Name = "label3";
            label3.Size = new Size(71, 20);
            label3.TabIndex = 0;
            label3.Text = "Nội dung";
            // 
            // txtNoiDung
            // 
            txtNoiDung.Location = new Point(12, 138);
            txtNoiDung.Name = "txtNoiDung";
            txtNoiDung.Size = new Size(616, 377);
            txtNoiDung.TabIndex = 2;
            txtNoiDung.Text = "";
            // 
            // button1
            // 
            button1.Location = new Point(651, 32);
            button1.Margin = new Padding(3, 3, 12, 20);
            button1.Name = "button1";
            button1.Size = new Size(122, 29);
            button1.TabIndex = 3;
            button1.Text = "Gửi";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(651, 81);
            button2.Margin = new Padding(3, 0, 12, 3);
            button2.Name = "button2";
            button2.Size = new Size(122, 29);
            button2.TabIndex = 4;
            button2.Text = "Tệp đính kèm";
            button2.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            listView1.Location = new Point(12, 521);
            listView1.Margin = new Padding(3, 3, 3, 12);
            listView1.Name = "listView1";
            listView1.Size = new Size(616, 121);
            listView1.TabIndex = 5;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.Visible = false;
            // 
            // SendEmailForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(839, 667);
            Controls.Add(listView1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtNoiDung);
            Controls.Add(label3);
            Controls.Add(txtTieuDe);
            Controls.Add(label2);
            Controls.Add(txtNguoiNhan);
            Controls.Add(label1);
            Name = "SendEmailForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thư mới";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNguoiNhan;
        private Label label2;
        private TextBox txtTieuDe;
        private Label label3;
        private RichTextBox txtNoiDung;
        private Button button1;
        private Button button2;
        private ListView listView1;
    }
}