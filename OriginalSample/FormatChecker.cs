using System;
using System.Globalization;

namespace OriginalSample
{
    public class FormatChecker
    {
        public bool CheckHeader(string source)
        {
            if (2 >= source.Length) return false;
            int len = 2 - 0 + 1;
            return source.Substring(0, len).Contains("965");
        }
        public  bool CheckFirstDateTime(string source)
        {
            if (20 >= source.Length) return false;
            int len = 20 - 13 + 1;
            string subString = source.Substring(13, len);
            DateTime d = new DateTime();
            bool ans = DateTime.TryParseExact(subString, "yyyyMMdd", CultureInfo.InvariantCulture, DateTimeStyles.None, out d);
            if (d == DateTime.MinValue)
                return false;
            return ans;
        }
    }
}