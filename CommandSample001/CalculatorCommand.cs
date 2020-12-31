namespace CommandSample002
{
    public class CalculatorCommand
    {
        private readonly Calculator _calculator;
        private readonly string _myOperator;
        private readonly double _operand;

        public CalculatorCommand(Calculator calculator, string myOperator, double operand)
        {
            _calculator = calculator;
            _myOperator = myOperator;
            _operand = operand;
        }

        public void Execute()
        {
            _calculator.Operate(_myOperator, _operand);
        }
    }
}