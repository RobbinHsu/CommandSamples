using System;
using System.Globalization;

namespace OriginalSample
{
    public class CheckFirstDateTimeCommand : CheckCommandBase
    {
        private readonly IFormatChecker _formatChecker;

        public CheckFirstDateTimeCommand(IFormatChecker checker) : base(checker)
        {
            _formatChecker = checker;
        }

        public override bool Execute(string source)
        {
            return _formatChecker.CheckFirstDateTime(source);
        }
    }
}