namespace Client_Form.Model
{
    public class HRegisterInfo
    {
        public string username;
        public string password;
        public string fullName;
        public string emailAddress;

        public HRegisterInfo(string username, string password, string fullName, string emailAddress)
        {
            this.username = username;
            this.password = password;
            this.fullName = fullName;
            this.emailAddress = emailAddress;
        }
    }
}
