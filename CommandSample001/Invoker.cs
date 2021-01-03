using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandSample001
{
    public class Invoker
    {
        protected Calculator _calculator;
        private int _executeCount;
        private List<CalculatorCommand> _historyCommands = new List<CalculatorCommand>();

        public Invoker()
        {
            _calculator = new Calculator();
        }

        public void Compute(string myOperator, double operand)
        {
            var command = new CalculatorCommand(_calculator, myOperator, operand);
            command.Execute();
            _historyCommands.Add(command);
            _executeCount++;
        }

        public void Undo(int levels)
        {
            for (var i = 0; i < levels; i++)
            {
                var index = _executeCount - 1;
                var calculatorCommand = _historyCommands[index];
                calculatorCommand.UnExecute();
                _executeCount = index;
            }
        }

        public void Redo(int levels)
        {
            for (var i = 0; i < levels; i++)
            {
                var calculatorCommand = _historyCommands[_executeCount];
                calculatorCommand.Execute();
                _executeCount += 1;
            }
        }
    }
}