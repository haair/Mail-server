﻿namespace Client_Form
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
            ((System.ComponentModel.ISupportInitialize)tbl_tep_dinh_kem).BeginInit();
            SuspendLayout();
            // 
            // txtContent
            // 
            txtContent.Location = new Point(10, 92);
            txtContent.Margin = new Padding(3, 2, 10, 9);
            txtContent.Name = "txtContent";
            txtContent.ReadOnly = true;
            txtContent.Size = new Size(619, 318);
            txtContent.TabIndex = 1;
            txtContent.Text = resources.GetString("txtContent.Text");
            // 
            // txtSubject
            // 
            txtSubject.AutoSize = true;
            txtSubject.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtSubject.Location = new Point(10, 74);
            txtSubject.Name = "txtSubject";
            txtSubject.Size = new Size(40, 15);
            txtSubject.TabIndex = 2;
            txtSubject.Text = "label1";
            // 
            // txtSender
            // 
            txtSender.AutoSize = true;
            txtSender.Location = new Point(11, 7);
            txtSender.Margin = new Padding(3, 0, 0, 8);
            txtSender.Name = "txtSender";
            txtSender.Size = new Size(42, 15);
            txtSender.TabIndex = 4;
            txtSender.Text = "Gửi từ:";
            // 
            // txtTime
            // 
            txtTime.AutoSize = true;
            txtTime.Location = new Point(10, 29);
            txtTime.Name = "txtTime";
            txtTime.Size = new Size(38, 15);
            txtTime.TabIndex = 5;
            txtTime.Text = "label1";
            // 
            // tbl_tep_dinh_kem
            // 
            tbl_tep_dinh_kem.AllowUserToAddRows = false;
            tbl_tep_dinh_kem.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tbl_tep_dinh_kem.ColumnHeadersVisible = false;
            tbl_tep_dinh_kem.Columns.AddRange(new DataGridViewColumn[] { Column3, Column1, Column2 });
            tbl_tep_dinh_kem.Location = new Point(11, 442);
            tbl_tep_dinh_kem.Margin = new Padding(3, 2, 10, 9);
            tbl_tep_dinh_kem.Name = "tbl_tep_dinh_kem";
            tbl_tep_dinh_kem.ReadOnly = true;
            tbl_tep_dinh_kem.RowHeadersVisible = false;
            tbl_tep_dinh_kem.RowHeadersWidth = 51;
            tbl_tep_dinh_kem.RowTemplate.Height = 29;
            tbl_tep_dinh_kem.Size = new Size(618, 141);
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
            lb_tep_dinh_kem.Location = new Point(11, 424);
            lb_tep_dinh_kem.Name = "lb_tep_dinh_kem";
            lb_tep_dinh_kem.Size = new Size(87, 15);
            lb_tep_dinh_kem.TabIndex = 7;
            lb_tep_dinh_kem.Text = "Tệp đính kèm:";
            // 
            // label_from
            // 
            label_from.AutoSize = true;
            label_from.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label_from.Location = new Point(53, 7);
            label_from.Margin = new Padding(0, 0, 3, 0);
            label_from.Name = "label_from";
            label_from.Size = new Size(40, 15);
            label_from.TabIndex = 8;
            label_from.Text = "label1";
            // 
            // ViewEmailForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(763, 611);
            Controls.Add(label_from);
            Controls.Add(lb_tep_dinh_kem);
            Controls.Add(tbl_tep_dinh_kem);
            Controls.Add(txtTime);
            Controls.Add(txtSender);
            Controls.Add(txtSubject);
            Controls.Add(txtContent);
            Margin = new Padding(3, 2, 3, 2);
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
    }
}