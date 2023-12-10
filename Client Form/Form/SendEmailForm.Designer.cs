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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            label1 = new Label();
            txtNguoiNhan = new TextBox();
            label2 = new Label();
            txtTieuDe = new TextBox();
            label3 = new Label();
            txtNoiDung = new RichTextBox();
            button1 = new Button();
            button2 = new Button();
            table_attachment = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            lb_tep_dinh_kem = new Label();
            ((System.ComponentModel.ISupportInitialize)table_attachment).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 16);
            label1.Margin = new Padding(3, 12, 3, 0);
            label1.Name = "label1";
            label1.Size = new Size(96, 20);
            label1.TabIndex = 0;
            label1.Text = "Người nhận:";
            // 
            // txtNguoiNhan
            // 
            txtNguoiNhan.Location = new Point(114, 12);
            txtNguoiNhan.Margin = new Padding(3, 12, 20, 3);
            txtNguoiNhan.Name = "txtNguoiNhan";
            txtNguoiNhan.Size = new Size(514, 27);
            txtNguoiNhan.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(44, 61);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 0;
            label2.Text = "Tiêu đề:";
            // 
            // txtTieuDe
            // 
            txtTieuDe.Location = new Point(114, 58);
            txtTieuDe.Margin = new Padding(3, 3, 20, 3);
            txtTieuDe.Name = "txtTieuDe";
            txtTieuDe.Size = new Size(514, 27);
            txtTieuDe.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(30, 104);
            label3.Name = "label3";
            label3.Size = new Size(78, 20);
            label3.TabIndex = 0;
            label3.Text = "Nội dung:";
            // 
            // txtNoiDung
            // 
            txtNoiDung.Location = new Point(12, 127);
            txtNoiDung.Margin = new Padding(3, 3, 3, 12);
            txtNoiDung.Name = "txtNoiDung";
            txtNoiDung.Size = new Size(616, 377);
            txtNoiDung.TabIndex = 2;
            txtNoiDung.Text = "";
            // 
            // button1
            // 
            button1.Location = new Point(651, 12);
            button1.Margin = new Padding(3, 12, 12, 20);
            button1.Name = "button1";
            button1.Size = new Size(122, 29);
            button1.TabIndex = 3;
            button1.Text = "Gửi";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(651, 61);
            button2.Margin = new Padding(3, 0, 12, 3);
            button2.Name = "button2";
            button2.Size = new Size(122, 29);
            button2.TabIndex = 4;
            button2.Text = "Tệp đính kèm";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // table_attachment
            // 
            table_attachment.AllowUserToAddRows = false;
            table_attachment.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            table_attachment.ColumnHeadersVisible = false;
            table_attachment.Columns.AddRange(new DataGridViewColumn[] { Column1, Column3, Column2 });
            table_attachment.Location = new Point(12, 544);
            table_attachment.Margin = new Padding(3, 3, 3, 12);
            table_attachment.Name = "table_attachment";
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            table_attachment.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            table_attachment.RowHeadersVisible = false;
            table_attachment.RowHeadersWidth = 50;
            table_attachment.RowTemplate.Height = 29;
            table_attachment.Size = new Size(616, 150);
            table_attachment.TabIndex = 5;
            table_attachment.Visible = false;
            // 
            // Column1
            // 
            Column1.HeaderText = "Tên tệp";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 200;
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column3.HeaderText = "Path";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            // 
            // Column2
            // 
            Column2.FillWeight = 50F;
            Column2.HeaderText = "Xóa";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 70;
            // 
            // lb_tep_dinh_kem
            // 
            lb_tep_dinh_kem.AutoSize = true;
            lb_tep_dinh_kem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lb_tep_dinh_kem.Location = new Point(12, 521);
            lb_tep_dinh_kem.Name = "lb_tep_dinh_kem";
            lb_tep_dinh_kem.Size = new Size(108, 20);
            lb_tep_dinh_kem.TabIndex = 6;
            lb_tep_dinh_kem.Text = "Tệp đính kèm:";
            lb_tep_dinh_kem.Visible = false;
            // 
            // SendEmailForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(839, 730);
            Controls.Add(lb_tep_dinh_kem);
            Controls.Add(table_attachment);
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
            ((System.ComponentModel.ISupportInitialize)table_attachment).EndInit();
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
        private DataGridView table_attachment;
        private Label lb_tep_dinh_kem;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column2;
    }
}