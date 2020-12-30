using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OriginalSample
{
    public class CheckResult
    {
        public string Source { get; set; }
        public bool Result { get; set; }


    }
    public class FormatChecker
    {
        public CheckResult Check(string source)
        {
            var result = new CheckResult() { Source = source };
            result.Result = Logic(result.Source);
            return result;
        }

        public bool Check965(string source)
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

        public bool Logic(string source) 
        {
            List<bool> result = new List<bool>();
            int count = 0; 
            result.Add(Check965(source));
            result.Add(CheckFirstDateTime(source));
            result.Add(CheckSecondDateTime(source));
            foreach (var r in result) 
            {
                if (r == true) count++;
            }
            if (count == result.Count)
                return true;
            return false;
        }
    }
}
