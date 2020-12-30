using System;
using System.Collections.Generic;

namespace OriginalSample
{
    public class Invoker
    {
        private List<Func<string, bool>> _commands = new List<Func<string, bool>>();


        public void AddCommand(Func<string, bool> execute)
        {
            _commands.Add(execute);
        }

        public CheckResult CheckResult(string source)
        {
            var result = new CheckResult() {Source = source};
            foreach (var command in _commands)
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