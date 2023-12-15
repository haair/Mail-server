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
            label1.Location = new Point(10, 12);
            label1.Margin = new Padding(3, 9, 3, 0);
            label1.Name = "label1";
            label1.Size = new Size(75, 15);
            label1.TabIndex = 0;
            label1.Text = "Người nhận:";
            // 
            // txtNguoiNhan
            // 
            txtNguoiNhan.Location = new Point(100, 9);
            txtNguoiNhan.Margin = new Padding(3, 9, 18, 2);
            txtNguoiNhan.Name = "txtNguoiNhan";
            txtNguoiNhan.Size = new Size(450, 23);
            txtNguoiNhan.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(38, 46);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 0;
            label2.Text = "Tiêu đề:";
            // 
            // txtTieuDe
            // 
            txtTieuDe.Location = new Point(100, 44);
            txtTieuDe.Margin = new Padding(3, 2, 18, 2);
            txtTieuDe.Name = "txtTieuDe";
            txtTieuDe.Size = new Size(450, 23);
            txtTieuDe.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(26, 78);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 0;
            label3.Text = "Nội dung:";
            // 
            // txtNoiDung
            // 
            txtNoiDung.Location = new Point(10, 95);
            txtNoiDung.Margin = new Padding(3, 2, 3, 9);
            txtNoiDung.Name = "txtNoiDung";
            txtNoiDung.Size = new Size(540, 284);
            txtNoiDung.TabIndex = 2;
            txtNoiDung.Text = "";
            // 
            // button1
            // 
            button1.Location = new Point(570, 9);
            button1.Margin = new Padding(3, 9, 10, 15);
            button1.Name = "button1";
            button1.Size = new Size(107, 22);
            button1.TabIndex = 3;
            button1.Text = "Gửi";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(570, 46);
            button2.Margin = new Padding(3, 0, 10, 2);
            button2.Name = "button2";
            button2.Size = new Size(107, 22);
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
            table_attachment.Location = new Point(10, 408);
            table_attachment.Margin = new Padding(3, 2, 3, 9);
            table_attachment.Name = "table_attachment";
            table_attachment.ReadOnly = true;
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
            table_attachment.Size = new Size(539, 112);
            table_attachment.TabIndex = 5;
            table_attachment.Visible = false;
            table_attachment.CellClick += table_attachment_CellClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "Tên tệp";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 200;
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column3.HeaderText = "Path";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.FillWeight = 50F;
            Column2.HeaderText = "Xóa";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 70;
            // 
            // lb_tep_dinh_kem
            // 
            lb_tep_dinh_kem.AutoSize = true;
            lb_tep_dinh_kem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lb_tep_dinh_kem.Location = new Point(10, 391);
            lb_tep_dinh_kem.Name = "lb_tep_dinh_kem";
            lb_tep_dinh_kem.Size = new Size(87, 15);
            lb_tep_dinh_kem.TabIndex = 6;
            lb_tep_dinh_kem.Text = "Tệp đính kèm:";
            lb_tep_dinh_kem.Visible = false;
            // 
            // SendEmailForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(734, 548);
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
            Margin = new Padding(3, 2, 3, 2);
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