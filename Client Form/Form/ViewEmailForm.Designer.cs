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
            SuspendLayout();
            // 
            // txtContent
            // 
            txtContent.Location = new Point(12, 122);
            txtContent.Name = "txtContent";
            txtContent.ReadOnly = true;
            txtContent.Size = new Size(707, 423);
            txtContent.TabIndex = 1;
            txtContent.Text = resources.GetString("txtContent.Text");
            // 
            // txtSubject
            // 
            txtSubject.AutoSize = true;
            txtSubject.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtSubject.Location = new Point(12, 99);
            txtSubject.Name = "txtSubject";
            txtSubject.Size = new Size(51, 20);
            txtSubject.TabIndex = 2;
            txtSubject.Text = "label1";
            // 
            // txtSender
            // 
            txtSender.AutoSize = true;
            txtSender.Location = new Point(13, 9);
            txtSender.Margin = new Padding(3, 0, 3, 10);
            txtSender.Name = "txtSender";
            txtSender.Size = new Size(50, 20);
            txtSender.TabIndex = 4;
            txtSender.Text = "label2";
            // 
            // txtTime
            // 
            txtTime.AutoSize = true;
            txtTime.Location = new Point(12, 39);
            txtTime.Name = "txtTime";
            txtTime.Size = new Size(50, 20);
            txtTime.TabIndex = 5;
            txtTime.Text = "label1";
            // 
            // ViewEmailForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(872, 522);
            Controls.Add(txtTime);
            Controls.Add(txtSender);
            Controls.Add(txtSubject);
            Controls.Add(txtContent);
            Name = "ViewEmailForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Email";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox txtContent;
        private Label txtSubject;
        private Label txtSender;
        private Label txtTime;
    }
}