using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OriginalSample
{
    public class Inovker
    {
        private readonly CheckFirstDateTimeCommand _checkFirstDateTimeCommand = new CheckFirstDateTimeCommand();
        private readonly CheckSecondDateTimeCommand _checkSecondDateTimeCommand = new CheckSecondDateTimeCommand();

        public CheckResult Action(string source)
        {
            var checker = new FormatChecker();
            var result = new CheckResult() { Source = source };
            var commands = new List<Func<string, bool>>()
            {
                new CheckHeaderCommand(checker).Execute,
                _checkFirstDateTimeCommand.Exectue,
                _checkSecondDateTimeCommand.Execute,
            };

            foreach (var command in commands)
            {
                result.Result = command(source);
                if (result.Result == false)
                {
                    break;
                }
            }
          
            return result;
        }
    }
}
