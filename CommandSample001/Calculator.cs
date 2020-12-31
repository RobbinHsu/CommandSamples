using System;
using System.Collections.Generic;

namespace CommandSample002
{
    public class Calculator
    {
        protected double _currentValue;
        private Dictionary<string, Func<double, double>> _dictionary;

        public Calculator()
        {
            CreateOperations();
        }

        public void Operate(string myOperator, double operand)
        {
            _currentValue = _dictionary[myOperator].Invoke(operand);
            Console.WriteLine($"{myOperator} {operand} 之後目前的值為 {_currentValue}");
        }

        private void CreateOperations()
        {
            _dictionary = new Dictionary<string, Func<double, double>>
            {
                {"+", (x) => _currentValue + x},
                {"-", (x) => _currentValue - x},
                {"*", (x) => _currentValue * x},
                {"/", (x) => _currentValue / x},
            };
        }
    }
}