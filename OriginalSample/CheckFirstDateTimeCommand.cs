using System;
using System.Globalization;

namespace OriginalSample
{
    public class CheckFirstDateTimeCommand : CheckCommandBase
    {
        private readonly FormatChecker _formatChecker;

        public CheckFirstDateTimeCommand(FormatChecker checker) : base(checker)
        {
            _formatChecker = checker;
        }

        public override bool Execute(string source)
        {
            return _formatChecker.CheckFirstDateTime(source);
        }
    }
}