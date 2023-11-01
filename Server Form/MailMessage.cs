using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server_Form
{
    public class MailMessage
    {
        public int messageID;
        public int mailboxID;
        public string sender;
        public string recipient;
        public string subject;
        public string body;
        public int timestamp;
        public int status;

        public MailMessage() { }
    }
}
