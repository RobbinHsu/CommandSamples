using System;
using System.Collections.Generic;
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

            
            return result;
        }
    }
}
