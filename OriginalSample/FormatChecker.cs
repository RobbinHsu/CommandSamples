using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OriginalSample
{
    public class FormatChecker
    {
        public CheckResult Check(string source)
        {
            var result = new CheckResult() {Source = source};

            if (source.Length == 29)
            {
                if (source.Substring(0, 3) == "965")
                {
                    result.Result = true;
                }
            }

            return result;
        }
    }
}