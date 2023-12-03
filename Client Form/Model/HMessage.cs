using Client_Form.Model;

namespace Client_Form
{
    public class HMessage
    {
        public int id;
        public HInfo info;
        public string[] listString = new string[50];
        public int[] listInt = new int[50];
        public List<HEmail> listMail = new();
        public int indexStr_w = 0;
        public int indexStr_r = 0;
        public int indexInt_w = 0;
        public int indexInt_r = 0;
        public int indexEmail_w = 0;
        public int indexEmail_r = 0;

        public void WriteString(string str)
        {
            listString[indexStr_w++] = str;
        }

        public string ReadString()
        {
            return listString[indexStr_r++];
        }

        public void WriteInt(int i)
        {
            listInt[indexInt_w++] = i;
        }

        public int ReadInt()
        {
            return listInt[indexInt_r++];
        }

        public void WriteEmail(HEmail email)
        {
            listMail[indexEmail_w++] = email;
        }

        public HEmail ReadEmail()
        {
            return listMail[indexEmail_r++];
        }

        public void AddEmail(HEmail hEmail)
        {
            listMail.Add(hEmail);
        }
    }
}

