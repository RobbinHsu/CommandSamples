using System;
using System.Globalization;

namespace OriginalSample
{
    public class CheckSecondDateTimeCommand
    {
        private readonly FormatChecker _formatChecker = new FormatChecker();

        public CheckSecondDateTimeCommand(FormatChecker checker)
        {
            _formatChecker = checker;
        }

        public bool Execute(string source)
        {
            return _formatChecker.CheckSecondDateTime(source);
        }

    }
}