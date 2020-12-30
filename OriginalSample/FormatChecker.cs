using System;
using System.Globalization;

namespace OriginalSample
{
    public class FormatChecker
    {
        public bool CheckSecondDateTime(string source)
        {
            if (28 >= source.Length) return false;
            var len = 28 - 21 + 1;
            var subString = source.Substring(21, len);
            var d = new DateTime();
            var ans = DateTime.TryParseExact(subString, "yyyyMMdd", CultureInfo.InvariantCulture, DateTimeStyles.None,
                out d);
            if (d == DateTime.MinValue)
                return false;
            return ans;
        }

        public bool CheckHeader(string source)
        {
            if (2 >= source.Length) return false;
            var len = 2 - 0 + 1;
            return source.Substring(0, len).Contains("965");
        }

        public bool CheckFirstDateTime(string source)
        {
            if (20 >= source.Length) return false;
            var len = 20 - 13 + 1;
            var subString = source.Substring(13, len);
            var d = new DateTime();
            var ans = DateTime.TryParseExact(subString, "yyyyMMdd", CultureInfo.InvariantCulture, DateTimeStyles.None,
                out d);
            if (d == DateTime.MinValue)
                return false;
            return ans;
        }
    }
}