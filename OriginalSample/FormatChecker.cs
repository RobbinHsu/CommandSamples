using System;
using System.Collections.Generic;
using System.Globalization;
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
                    DateTime firstDate;
                    if (DateTime.TryParseExact(source.Substring(13, 8), "yyyyMMdd", CultureInfo.InvariantCulture,
                        DateTimeStyles.None, out firstDate))
                    {
                        result.Result = true;
                    }
                }
            }

            return result;
        }
    }
}