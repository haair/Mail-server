namespace Client_Form.Model
{
    public class HEmail
    {
        public int messageID;
        public int mailboxID;
        public string sender;
        public string recipient;
        public string subject;
        public string body;
        public int timestamp;
        public int status;
        public List<HAttachment> attachments;

        public HEmail() { }

        public HEmail(int messageID, int mailboxID, string sender, string recipient, string subject, string body, int timestamp, int status, List<HAttachment> attachments)
        {
            this.messageID = messageID;
            this.mailboxID = mailboxID;
            this.sender = sender;
            this.recipient = recipient;
            this.subject = subject;
            this.body = body;
            this.timestamp = timestamp;
            this.status = status;
            this.attachments = attachments;
        }
    }
}
