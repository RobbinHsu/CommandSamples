using System;
using System.Globalization;

namespace OriginalSample
{
    public class CheckFirstDateTimeCommand
    {
        private readonly FormatChecker _formatChecker = new FormatChecker();

        public CheckFirstDateTimeCommand(FormatChecker checker)
        {
            _formatChecker = checker;
        }

        public bool Execute(string source)
        {
            return _formatChecker.CheckFirstDateTime(source);
        }

    }
}