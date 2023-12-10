namespace Server_Form
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            HServer.Start();
            HServer.form = this;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void AddMessage(string message)
        {
            log_txt.Invoke((MethodInvoker)(() => log_txt.AppendText(message + "\n")));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //string ori = "C:\\Users\\HAAIR\\Pictures\\LGB-Gay.jpg";
                //string desPath = "C:\\Users\\HAAIR\\Desktop\\New folder (2)\\Test Folder\\hihi\\NRO.png";
                //byte[] fileData = File.ReadAllBytes(ori);
                //FileInfo fileInfo = new FileInfo(desPath);
                //fileInfo.Directory.Create();
                //File.WriteAllBytes(desPath, fileData);
                Thread t = new Thread(() =>
                {
                    using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
                    {
                        DialogResult result = folderDialog.ShowDialog();

                        if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderDialog.SelectedPath))
                        {
                            string selectedFolder = folderDialog.SelectedPath;
                            // Do something with the selected folder path
                            MessageBox.Show("Selected Folder: " + selectedFolder);
                        }
                    }
                });

                t.SetApartmentState(ApartmentState.STA);
                t.Start();
                t.Join();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}