using System;
using System.Collections.Generic;
using FakeDataLibrary;

namespace OriginalSample
{
    public class CommandSample
    {
        public List<CheckResult> Command(Action createData)
        {
            var checker = new FormatChecker();
            var results = new List<CheckResult>();

            foreach (var item in FakeDataSource.Data(createData))
            {
                results.Add(checker.Check(item));
            }

            return results;
        }
    }
}