using System;
using System.Globalization;

namespace OriginalSample
{
    public class CheckSecondDateTimeCommand
    {
        public bool Execute(string source)
        {
            if (28 >= source.Length) return false;
            int len = 28 - 21 + 1;
            string subString = source.Substring(21, len);
            DateTime d = new DateTime();
            bool ans = DateTime.TryParseExact(subString, "yyyyMMdd", CultureInfo.InvariantCulture, DateTimeStyles.None, out d);
            if (d == DateTime.MinValue)
                return false;
            return ans;
        }
    }
}