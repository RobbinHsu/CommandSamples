using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandSample002
{
    public class Invoker
    {
        protected Calculator _calculator;

        public Calculator Calculator
        {
            get { return _calculator; }
        }

        public Invoker()
        {
            _calculator = new Calculator();
        }

        public void Compute(string myOperator, double operand)
        {
            Calculator.Operate(myOperator, operand);
        }

        public void Undo(int levels)
        {
        }

        public void Redo(int levels)
        {
        }
    }
}