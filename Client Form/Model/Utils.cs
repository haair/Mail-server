namespace Client_Form.Model
{
    public class Utils
    {
        public static HClient client;
        public static LoginForm loginForm;
        public static MainForm mainForm;
        public static HInfo info;

        public static List<HEmail> allEmail = new();
        public static List<HEmail> mailNhan = new();
        public static List<HEmail> mailGui = new();
        public static List<HEmail> mailBin = new();

        public static string GetTimeAgo(int second)
        {
            int timeNow = CurrentTimeSeconds();
            int range = timeNow - second;
            string dtString;
            DateTimeOffset dateTimeOffset = DateTimeOffset.FromUnixTimeSeconds(second);
            DateTime dt = dateTimeOffset.UtcDateTime;
            if (range < 86400)
            {
                dtString = dt.ToString("HH:mm");
            }
            else
            {
                dtString = dt.ToString("dd/MM");
            }
            return dtString;
        }

        public static string GetTimeAgo1(int second)
        {
            DateTimeOffset dateTimeOffset = DateTimeOffset.FromUnixTimeSeconds(second);
            DateTime dt = dateTimeOffset.UtcDateTime;
            return dt.ToString("dd/MM/yyyy HH:mm");
        }

        public static string GetTimeAgo2(int second)
        {
            int timeNow = CurrentTimeSeconds();
            int range = timeNow - second;
            string dtString;
            DateTimeOffset dateTimeOffset = DateTimeOffset.FromUnixTimeSeconds(second);
            DateTime dt = dateTimeOffset.UtcDateTime;
            TimeSpan tp = DateTime.Now - dt;

            if (tp.TotalDays >= 1)
            {
                dtString = (int)tp.TotalDays + " ngày trước";
            }
            else if (tp.TotalHours >= 1)
            {
                dtString = (int)tp.TotalHours + " giờ trước";
            }
            else if (tp.TotalMinutes >= 1)
            {
                dtString = (int)tp.TotalMinutes + " phút trước";
            }
            else
            {
                dtString = (int)tp.TotalSeconds + " giây trước";
            }
            return dtString;
        }

        public static int CurrentTimeSeconds()
        {
            DateTime epochStart = new(1970, 1, 1, 0, 0, 0, DateTimeKind.Local);
            TimeSpan elapsedTime = DateTime.Now - epochStart;
            int currentEpochTime = (int)elapsedTime.TotalSeconds;

            return currentEpochTime;
        }
    }
}
