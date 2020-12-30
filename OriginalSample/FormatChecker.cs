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
        public bool Check965(int start,int end,string source) 
        {
            if (end >= source.Length) return false;
            int len = end - start + 1 ;
            return source.Substring(start, len).Contains("965");
        }
        public bool CheckDateTime(int start, int end, string source) 
        {
            if (end >= source.Length) return false;
            int len = end - start + 1;
            string subString = source.Substring(start, len);
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
            result.Add(Check965(0, 2, source));
            result.Add(CheckDateTime(13, 20, source));
            result.Add(CheckDateTime(21, 28, source));
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
