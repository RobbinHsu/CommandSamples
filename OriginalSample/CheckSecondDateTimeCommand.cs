using System;
using System.Globalization;

namespace OriginalSample
{
    public class CheckSecondDateTimeCommand : CheckCommandBase
    {
        public CheckSecondDateTimeCommand(FormatChecker checker) : base(checker)
        {
        }

        public override bool Execute(string source)
        {
            return Checker.CheckSecondDateTime(source);
        }

    }
}