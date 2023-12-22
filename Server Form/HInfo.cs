namespace Server_Form
{
    public class HInfo
    {
        public string username;
        public string emailAddress;
        public int mailBox;
        public string fullName;

        public HInfo(string username, string emailAddress, int mailBox, string fullName)
        {
            this.username = username;
            this.emailAddress = emailAddress;
            this.mailBox = mailBox;
            this.fullName = fullName;
        }
    }
}
