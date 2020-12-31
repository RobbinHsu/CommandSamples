using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandSample002
{
    public class Invoker
    {
        protected Calculator _calculator;
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
        }

        public void Undo(int levels)
        {
        }

        public void Redo(int levels)
        {
        }
    }
}