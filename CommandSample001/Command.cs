using System.Collections.Generic;

namespace CommandSample001
{
    public class Command : ICommand
    {
        private readonly Calculator _calculator;
        private readonly string _myOperator;
        private readonly double _operand;

        public Command(Calculator calculator, string myOperator, double operand)
        {
            _calculator = calculator;
            _myOperator = myOperator;
            _operand = operand;
        }

        public void Execute()
        {
            _calculator.Operate(_myOperator, _operand);
        }

        public void UnExecute()
        {
            _calculator.Operate(ReverseOperator(_myOperator), _operand);
        }

        private string ReverseOperator(string myOperator)
        {
            var lookupReverse = new Dictionary<string, string>()
            {
                {"+", "-"},
                {"-", "+"},
                {"*", "/"},
                {"/", "*"},
            };
            return lookupReverse[myOperator];
        }
    }
}