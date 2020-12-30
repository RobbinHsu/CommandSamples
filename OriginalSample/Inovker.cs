using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OriginalSample
{
    public class Inovker
    {
        public CheckResult Action(string source)
        {
            var result = new CheckResult() { Source = source };
            var commands = new List<Func<string, bool>>()
            {
                CheckHeader,
                CheckFirstDateTime,
                CheckSecondDateTime,
            };

            foreach (var command in commands)
            {
                result.Result = command(source);
                if (result.Result == false)
                {
                    break;
                }
            }
          
            return result;
        }

        public bool CheckHeader(string source)
        {
            if (2 >= source.Length) return false;
            int len = 2 - 0 + 1 ;
            return source.Substring(0, len).Contains("965");
        }

        public bool CheckFirstDateTime(string source)
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

        public bool CheckSecondDateTime(string source)
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
