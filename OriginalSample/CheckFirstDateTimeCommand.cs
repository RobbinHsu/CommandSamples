using System;
using System.Globalization;

namespace OriginalSample
{
    public class CheckFirstDateTimeCommand
    {
        public bool Exectue(string source)
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