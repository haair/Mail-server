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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            button1 = new Button();
            button3 = new Button();
            label1 = new Label();
            button4 = new Button();
            label2 = new Label();
            btn_restore = new Button();
            tabPage4 = new TabPage();
            tbl_thung_rac = new DataGridView();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            tabPage2 = new TabPage();
            tbl_thu_da_gui = new DataGridView();
            tabPage1 = new TabPage();
            tbl_hop_thu_den = new DataGridView();
            Column0 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            tabControl1 = new TabControl();
            contextMenuStrip1 = new ContextMenuStrip(components);
            đánhDấuToolStripMenuItem = new ToolStripMenuItem();
            button5 = new Button();
            textBox1 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tbl_thung_rac).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tbl_thu_da_gui).BeginInit();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tbl_hop_thu_den).BeginInit();
            tabControl1.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackgroundImage = Properties.Resources.write;
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.Location = new Point(886, 182);
            button1.Margin = new Padding(2, 3, 5, 20);
            button1.Name = "button1";
            button1.Size = new Size(60, 60);
            button1.TabIndex = 1;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.BackgroundImage = Properties.Resources.bin_black;
            button3.BackgroundImageLayout = ImageLayout.Zoom;
            button3.Location = new Point(1026, 182);
            button3.Margin = new Padding(5, 3, 5, 3);
            button3.Name = "button3";
            button3.Size = new Size(60, 60);
            button3.TabIndex = 1;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(808, 39);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 2;
            label1.Click += label1_Click;
            // 
            // button4
            // 
            button4.BackgroundImage = Properties.Resources.refresh_page_option;
            button4.BackgroundImageLayout = ImageLayout.Zoom;
            button4.Location = new Point(886, 287);
            button4.Margin = new Padding(2, 3, 2, 3);
            button4.Name = "button4";
            button4.Size = new Size(60, 60);
            button4.TabIndex = 3;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(886, 29);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(59, 23);
            label2.TabIndex = 4;
            label2.Text = "label2";
            // 
            // btn_restore
            // 
            btn_restore.BackgroundImage = Properties.Resources.undo_circular_arrow;
            btn_restore.BackgroundImageLayout = ImageLayout.Zoom;
            btn_restore.Enabled = false;
            btn_restore.Location = new Point(1096, 182);
            btn_restore.Margin = new Padding(5, 4, 3, 4);
            btn_restore.Name = "btn_restore";
            btn_restore.Size = new Size(60, 60);
            btn_restore.TabIndex = 5;
            btn_restore.UseVisualStyleBackColor = true;
            btn_restore.Click += btn_restore_Click;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(tbl_thung_rac);
            tabPage4.Location = new Point(4, 29);
            tabPage4.Margin = new Padding(2, 3, 2, 3);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(2, 3, 2, 3);
            tabPage4.Size = new Size(858, 644);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Thùng rác";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // tbl_thung_rac
            // 
            tbl_thung_rac.AllowUserToAddRows = false;
            tbl_thung_rac.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.LightGray;
            tbl_thung_rac.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            tbl_thung_rac.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tbl_thung_rac.CellBorderStyle = DataGridViewCellBorderStyle.None;
            tbl_thung_rac.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            tbl_thung_rac.ColumnHeadersHeight = 45;
            tbl_thung_rac.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            tbl_thung_rac.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6, Column4, dataGridViewTextBoxColumn7, dataGridViewTextBoxColumn8 });
            tbl_thung_rac.Dock = DockStyle.Fill;
            tbl_thung_rac.Location = new Point(2, 3);
            tbl_thung_rac.Margin = new Padding(2, 3, 2, 3);
            tbl_thung_rac.Name = "tbl_thung_rac";
            tbl_thung_rac.ReadOnly = true;
            tbl_thung_rac.RowHeadersVisible = false;
            tbl_thung_rac.RowHeadersWidth = 62;
            tbl_thung_rac.RowTemplate.Height = 45;
            tbl_thung_rac.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tbl_thung_rac.Size = new Size(854, 638);
            tbl_thung_rac.TabIndex = 2;
            tbl_thung_rac.CellDoubleClick += tbl_thung_rac_CellDoubleClick;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.HeaderText = "Email Id";
            dataGridViewTextBoxColumn5.MinimumWidth = 6;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            dataGridViewTextBoxColumn5.Visible = false;
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
            Column4.MinimumWidth = 6;
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
            // tabPage2
            // 
            tabPage2.Controls.Add(tbl_thu_da_gui);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Margin = new Padding(2, 3, 2, 3);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(2, 3, 2, 3);
            tabPage2.Size = new Size(858, 644);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Thư đã gửi";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tbl_thu_da_gui
            // 
            tbl_thu_da_gui.AllowUserToAddRows = false;
            tbl_thu_da_gui.AllowUserToResizeRows = false;
            tbl_thu_da_gui.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            tbl_thu_da_gui.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tbl_thu_da_gui.CellBorderStyle = DataGridViewCellBorderStyle.None;
            tbl_thu_da_gui.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            tbl_thu_da_gui.ColumnHeadersHeight = 45;
            tbl_thu_da_gui.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            tbl_thu_da_gui.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4 });
            tbl_thu_da_gui.Dock = DockStyle.Fill;
            tbl_thu_da_gui.Location = new Point(2, 3);
            tbl_thu_da_gui.Margin = new Padding(2, 3, 2, 3);
            tbl_thu_da_gui.Name = "tbl_thu_da_gui";
            tbl_thu_da_gui.ReadOnly = true;
            tbl_thu_da_gui.RowHeadersVisible = false;
            tbl_thu_da_gui.RowHeadersWidth = 62;
            tbl_thu_da_gui.RowTemplate.Height = 45;
            tbl_thu_da_gui.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tbl_thu_da_gui.Size = new Size(854, 638);
            tbl_thu_da_gui.TabIndex = 1;
            tbl_thu_da_gui.CellDoubleClick += tbl_thu_da_gui_CellDoubleClick;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(tbl_hop_thu_den);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Margin = new Padding(2, 3, 2, 3);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(2, 3, 2, 3);
            tabPage1.Size = new Size(858, 644);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Hộp thư đến";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tbl_hop_thu_den
            // 
            tbl_hop_thu_den.AllowUserToAddRows = false;
            tbl_hop_thu_den.AllowUserToResizeRows = false;
            tbl_hop_thu_den.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            tbl_hop_thu_den.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tbl_hop_thu_den.BorderStyle = BorderStyle.Fixed3D;
            tbl_hop_thu_den.CellBorderStyle = DataGridViewCellBorderStyle.None;
            tbl_hop_thu_den.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            tbl_hop_thu_den.ColumnHeadersHeight = 45;
            tbl_hop_thu_den.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            tbl_hop_thu_den.Columns.AddRange(new DataGridViewColumn[] { Column0, Column1, Column2, Column3, Column5 });
            tbl_hop_thu_den.Dock = DockStyle.Fill;
            tbl_hop_thu_den.Location = new Point(2, 3);
            tbl_hop_thu_den.Margin = new Padding(2, 3, 2, 3);
            tbl_hop_thu_den.Name = "tbl_hop_thu_den";
            tbl_hop_thu_den.ReadOnly = true;
            tbl_hop_thu_den.RowHeadersVisible = false;
            tbl_hop_thu_den.RowHeadersWidth = 62;
            tbl_hop_thu_den.RowTemplate.Height = 45;
            tbl_hop_thu_den.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tbl_hop_thu_den.Size = new Size(854, 638);
            tbl_hop_thu_den.TabIndex = 0;
            tbl_hop_thu_den.CellDoubleClick += dataGridView1_CellDoubleClick;
            tbl_hop_thu_den.MouseClick += tbl_hop_thu_den_MouseClick;
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
            // Column5
            // 
            Column5.HeaderText = "Status";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Visible = false;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Dock = DockStyle.Left;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Margin = new Padding(2, 3, 20, 3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(866, 677);
            tabControl1.TabIndex = 0;
            tabControl1.Selecting += tabControl1_Selecting;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { đánhDấuToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(209, 28);
            // 
            // đánhDấuToolStripMenuItem
            // 
            đánhDấuToolStripMenuItem.Name = "đánhDấuToolStripMenuItem";
            đánhDấuToolStripMenuItem.Size = new Size(208, 24);
            đánhDấuToolStripMenuItem.Text = "Đánh dấu là đã đọc";
            đánhDấuToolStripMenuItem.Click += đánhDấuToolStripMenuItem_Click;
            // 
            // button5
            // 
            button5.BackgroundImage = Properties.Resources.open_message;
            button5.BackgroundImageLayout = ImageLayout.Zoom;
            button5.Location = new Point(956, 182);
            button5.Margin = new Padding(5, 4, 5, 4);
            button5.Name = "button5";
            button5.Size = new Size(60, 60);
            button5.TabIndex = 6;
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(886, 105);
            textBox1.Margin = new Padding(0, 3, 3, 20);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(270, 35);
            textBox1.TabIndex = 7;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(886, 79);
            label3.Name = "label3";
            label3.Size = new Size(174, 23);
            label3.TabIndex = 8;
            label3.Text = "Tìm kiếm trong thư:";
            // 
            // label4
            // 
            label4.BorderStyle = BorderStyle.Fixed3D;
            label4.Location = new Point(886, 262);
            label4.Margin = new Padding(3, 0, 3, 20);
            label4.Name = "label4";
            label4.Size = new Size(324, 2);
            label4.TabIndex = 9;
            // 
            // label5
            // 
            label5.BorderStyle = BorderStyle.Fixed3D;
            label5.Location = new Point(886, 157);
            label5.Margin = new Padding(3, 0, 3, 20);
            label5.Name = "label5";
            label5.Size = new Size(331, 2);
            label5.TabIndex = 9;
            // 
            // label6
            // 
            label6.BorderStyle = BorderStyle.Fixed3D;
            label6.Location = new Point(886, 57);
            label6.Margin = new Padding(3, 0, 3, 20);
            label6.Name = "label6";
            label6.Size = new Size(331, 2);
            label6.TabIndex = 9;
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
            dataGridViewTextBoxColumn2.HeaderText = "Đến";
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
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1192, 677);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(button5);
            Controls.Add(btn_restore);
            Controls.Add(label2);
            Controls.Add(button4);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(tabControl1);
            Margin = new Padding(2, 3, 2, 3);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hmail";
            FormClosed += MainForm_FormClosed;
            Load += MainForm_Load;
            tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)tbl_thung_rac).EndInit();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)tbl_thu_da_gui).EndInit();
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)tbl_hop_thu_den).EndInit();
            tabControl1.ResumeLayout(false);
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        private void TextBox1_GotFocus(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private Button button1;
        private Button button3;
        private Label label1;
        private Button button4;
        private Label label2;
        private Button btn_restore;
        private TabPage tabPage4;
        private DataGridView tbl_thung_rac;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private TabPage tabPage2;
        private DataGridView tbl_thu_da_gui;
        private TabPage tabPage1;
        private DataGridView tbl_hop_thu_den;
        private TabControl tabControl1;
        private DataGridViewTextBoxColumn Column0;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column5;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem đánhDấuToolStripMenuItem;
        private Button button5;
        private TextBox textBox1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}