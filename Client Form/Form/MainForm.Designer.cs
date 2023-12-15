namespace Client_Form
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tbl_hop_thu_den = new DataGridView();
            Column0 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            tabPage2 = new TabPage();
            tbl_thu_da_gui = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            tabPage3 = new TabPage();
            tabPage4 = new TabPage();
            tbl_thung_rac = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label1 = new Label();
            button4 = new Button();
            label2 = new Label();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tbl_hop_thu_den).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tbl_thu_da_gui).BeginInit();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tbl_thung_rac).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Dock = DockStyle.Left;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Margin = new Padding(2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(758, 508);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(tbl_hop_thu_den);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Margin = new Padding(2);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(2);
            tabPage1.Size = new Size(750, 480);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Hộp thư đến";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tbl_hop_thu_den
            // 
            tbl_hop_thu_den.AllowUserToAddRows = false;
            tbl_hop_thu_den.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tbl_hop_thu_den.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tbl_hop_thu_den.Columns.AddRange(new DataGridViewColumn[] { Column0, Column1, Column2, Column3 });
            tbl_hop_thu_den.Dock = DockStyle.Fill;
            tbl_hop_thu_den.Location = new Point(2, 2);
            tbl_hop_thu_den.Margin = new Padding(2);
            tbl_hop_thu_den.Name = "tbl_hop_thu_den";
            tbl_hop_thu_den.ReadOnly = true;
            tbl_hop_thu_den.RowHeadersVisible = false;
            tbl_hop_thu_den.RowHeadersWidth = 62;
            tbl_hop_thu_den.RowTemplate.Height = 33;
            tbl_hop_thu_den.Size = new Size(746, 476);
            tbl_hop_thu_den.TabIndex = 0;
            tbl_hop_thu_den.CellClick += dataGridView1_CellClick;
            tbl_hop_thu_den.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // Column0
            // 
            Column0.HeaderText = "Email Id";
            Column0.MinimumWidth = 6;
            Column0.Name = "Column0";
            Column0.ReadOnly = true;
            Column0.Visible = false;
            // 
            // Column1
            // 
            Column1.HeaderText = "Người gửi";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "Tiêu đề";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "Thời gian nhận";
            Column3.MinimumWidth = 8;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(tbl_thu_da_gui);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Margin = new Padding(2);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(2);
            tabPage2.Size = new Size(750, 480);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Thư đã gửi";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tbl_thu_da_gui
            // 
            tbl_thu_da_gui.AllowUserToAddRows = false;
            tbl_thu_da_gui.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tbl_thu_da_gui.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tbl_thu_da_gui.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4 });
            tbl_thu_da_gui.Dock = DockStyle.Fill;
            tbl_thu_da_gui.Location = new Point(2, 2);
            tbl_thu_da_gui.Margin = new Padding(2);
            tbl_thu_da_gui.Name = "tbl_thu_da_gui";
            tbl_thu_da_gui.ReadOnly = true;
            tbl_thu_da_gui.RowHeadersVisible = false;
            tbl_thu_da_gui.RowHeadersWidth = 62;
            tbl_thu_da_gui.RowTemplate.Height = 33;
            tbl_thu_da_gui.Size = new Size(746, 476);
            tbl_thu_da_gui.TabIndex = 1;
            tbl_thu_da_gui.CellDoubleClick += tbl_thu_da_gui_CellDoubleClick;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Email Id";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Người nhận";
            dataGridViewTextBoxColumn2.MinimumWidth = 8;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Tiêu đề";
            dataGridViewTextBoxColumn3.MinimumWidth = 8;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Thời gian gửi";
            dataGridViewTextBoxColumn4.MinimumWidth = 8;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 24);
            tabPage3.Margin = new Padding(2);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(2);
            tabPage3.Size = new Size(750, 480);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Tất cả thư";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(tbl_thung_rac);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Margin = new Padding(2);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(2);
            tabPage4.Size = new Size(750, 480);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Thùng rác";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // tbl_thung_rac
            // 
            tbl_thung_rac.AllowUserToAddRows = false;
            tbl_thung_rac.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tbl_thung_rac.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tbl_thung_rac.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6, Column4, dataGridViewTextBoxColumn7, dataGridViewTextBoxColumn8 });
            tbl_thung_rac.Dock = DockStyle.Fill;
            tbl_thung_rac.Location = new Point(2, 2);
            tbl_thung_rac.Margin = new Padding(2);
            tbl_thung_rac.Name = "tbl_thung_rac";
            tbl_thung_rac.ReadOnly = true;
            tbl_thung_rac.RowHeadersVisible = false;
            tbl_thung_rac.RowHeadersWidth = 62;
            tbl_thung_rac.RowTemplate.Height = 33;
            tbl_thung_rac.Size = new Size(746, 476);
            tbl_thung_rac.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(778, 54);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(79, 20);
            button1.TabIndex = 1;
            button1.Text = "Soạn thư";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(778, 95);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(79, 20);
            button2.TabIndex = 1;
            button2.Text = "Đăng xuất";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(778, 133);
            button3.Margin = new Padding(2);
            button3.Name = "button3";
            button3.Size = new Size(79, 20);
            button3.TabIndex = 1;
            button3.Text = "Xóa thư";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(707, 29);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 2;
            label1.Click += label1_Click;
            // 
            // button4
            // 
            button4.Location = new Point(778, 174);
            button4.Margin = new Padding(2);
            button4.Name = "button4";
            button4.Size = new Size(79, 20);
            button4.TabIndex = 3;
            button4.Text = "Refresh";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(778, 22);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 4;
            label2.Text = "label2";
            label2.Click += label2_Click;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.HeaderText = "Email Id";
            dataGridViewTextBoxColumn5.MinimumWidth = 6;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.HeaderText = "Người gửi";
            dataGridViewTextBoxColumn6.MinimumWidth = 8;
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.HeaderText = "Người nhận";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.HeaderText = "Tiêu đề";
            dataGridViewTextBoxColumn7.MinimumWidth = 8;
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            dataGridViewTextBoxColumn8.HeaderText = "Thời gian";
            dataGridViewTextBoxColumn8.MinimumWidth = 8;
            dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(880, 508);
            Controls.Add(label2);
            Controls.Add(button4);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(tabControl1);
            Margin = new Padding(2);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hmail";
            FormClosed += MainForm_FormClosed;
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)tbl_hop_thu_den).EndInit();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)tbl_thu_da_gui).EndInit();
            tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)tbl_thung_rac).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label1;
        private DataGridView tbl_hop_thu_den;
        private Button button4;
        private Label label2;
        private DataGridView tbl_thu_da_gui;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridView tbl_thung_rac;
        private DataGridViewTextBoxColumn Column0;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    }
}