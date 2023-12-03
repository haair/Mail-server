namespace Client_Form.Model
{
    public class HEmail
    {
        public int messagesId;
        public int mailboxId;
        public string sender;
        public string recipient;
        public string subject;
        public string body;
        public int timestamp;
        public int status;

        public HEmail(int messagesId, int mailboxId, string sender, string recipient, string subject, string body, int timestamp, int status)
        {
            this.messagesId = messagesId;
            this.mailboxId = mailboxId;
            this.sender = sender;
            this.recipient = recipient;
            this.subject = subject;
            this.body = body;
            this.timestamp = timestamp;
            this.status = status;
        }
    }
}
