namespace Client_Form
{
    partial class ViewEmailForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewEmailForm));
            txtContent = new RichTextBox();
            txtSubject = new Label();
            txtSender = new Label();
            txtTime = new Label();
            tbl_tep_dinh_kem = new DataGridView();
            Column3 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            lb_tep_dinh_kem = new Label();
            label_from = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)tbl_tep_dinh_kem).BeginInit();
            SuspendLayout();
            // 
            // txtContent
            // 
            txtContent.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtContent.Location = new Point(11, 123);
            txtContent.Margin = new Padding(3, 3, 11, 12);
            txtContent.Name = "txtContent";
            txtContent.ReadOnly = true;
            txtContent.Size = new Size(930, 483);
            txtContent.TabIndex = 1;
            txtContent.Text = resources.GetString("txtContent.Text");
            // 
            // txtSubject
            // 
            txtSubject.AutoSize = true;
            txtSubject.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            txtSubject.Location = new Point(11, 89);
            txtSubject.Name = "txtSubject";
            txtSubject.Size = new Size(79, 31);
            txtSubject.TabIndex = 2;
            txtSubject.Text = "label1";
            // 
            // txtSender
            // 
            txtSender.AutoSize = true;
            txtSender.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtSender.Location = new Point(13, 9);
            txtSender.Margin = new Padding(3, 0, 0, 11);
            txtSender.Name = "txtSender";
            txtSender.Size = new Size(61, 23);
            txtSender.TabIndex = 4;
            txtSender.Text = "Gửi từ:";
            // 
            // txtTime
            // 
            txtTime.AutoSize = true;
            txtTime.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtTime.Location = new Point(13, 34);
            txtTime.Name = "txtTime";
            txtTime.Size = new Size(55, 23);
            txtTime.TabIndex = 5;
            txtTime.Text = "label1";
            // 
            // tbl_tep_dinh_kem
            // 
            tbl_tep_dinh_kem.AllowUserToAddRows = false;
            tbl_tep_dinh_kem.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tbl_tep_dinh_kem.ColumnHeadersVisible = false;
            tbl_tep_dinh_kem.Columns.AddRange(new DataGridViewColumn[] { Column3, Column1, Column2 });
            tbl_tep_dinh_kem.Location = new Point(12, 641);
            tbl_tep_dinh_kem.Margin = new Padding(3, 3, 11, 12);
            tbl_tep_dinh_kem.Name = "tbl_tep_dinh_kem";
            tbl_tep_dinh_kem.ReadOnly = true;
            tbl_tep_dinh_kem.RowHeadersVisible = false;
            tbl_tep_dinh_kem.RowHeadersWidth = 51;
            tbl_tep_dinh_kem.RowTemplate.Height = 29;
            tbl_tep_dinh_kem.Size = new Size(928, 188);
            tbl_tep_dinh_kem.TabIndex = 6;
            tbl_tep_dinh_kem.CellClick += tbl_tep_dinh_kem_CellClick;
            // 
            // Column3
            // 
            Column3.HeaderText = "attID";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Visible = false;
            Column3.Width = 125;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column1.HeaderText = "Tên file";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "Tải xuống";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 200;
            // 
            // lb_tep_dinh_kem
            // 
            lb_tep_dinh_kem.AutoSize = true;
            lb_tep_dinh_kem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lb_tep_dinh_kem.Location = new Point(11, 618);
            lb_tep_dinh_kem.Name = "lb_tep_dinh_kem";
            lb_tep_dinh_kem.Size = new Size(108, 20);
            lb_tep_dinh_kem.TabIndex = 7;
            lb_tep_dinh_kem.Text = "Tệp đính kèm:";
            // 
            // label_from
            // 
            label_from.AutoSize = true;
            label_from.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label_from.Location = new Point(74, 9);
            label_from.Margin = new Padding(0, 0, 3, 0);
            label_from.Name = "label_from";
            label_from.Size = new Size(59, 23);
            label_from.TabIndex = 8;
            label_from.Text = "label1";
            // 
            // label1
            // 
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Location = new Point(12, 74);
            label1.Name = "label1";
            label1.Size = new Size(930, 2);
            label1.TabIndex = 9;
            label1.Click += label1_Click;
            // 
            // ViewEmailForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1036, 858);
            Controls.Add(label1);
            Controls.Add(label_from);
            Controls.Add(lb_tep_dinh_kem);
            Controls.Add(tbl_tep_dinh_kem);
            Controls.Add(txtTime);
            Controls.Add(txtSender);
            Controls.Add(txtSubject);
            Controls.Add(txtContent);
            MaximizeBox = false;
            Name = "ViewEmailForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Email";
            ((System.ComponentModel.ISupportInitialize)tbl_tep_dinh_kem).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox txtContent;
        private Label txtSubject;
        private Label txtSender;
        private Label txtTime;
        private DataGridView tbl_tep_dinh_kem;
        private Label lb_tep_dinh_kem;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private Label label_from;
        private Label label1;
    }
}