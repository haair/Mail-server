namespace Client_Form.Model
{
    public class HAttachment
    {
        public int attachmentID;
        public int messageID;
        public string fileName;
        public int fileSize;
        public string fileType;
        public byte[] data;

        public HAttachment() { }

        public HAttachment(int attachmentID, int messageID, string fileName, int fileSize, string fileType, byte[] data)
        {
            this.attachmentID = attachmentID;
            this.messageID = messageID;
            this.fileName = fileName;
            this.fileSize = fileSize;
            this.fileType = fileType;
            this.data = data;
        }
    }
}
