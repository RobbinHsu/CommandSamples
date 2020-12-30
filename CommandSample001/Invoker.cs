using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandSample002
{
    public class Invoker
    {
        protected double _currentValue;
        private Dictionary<string, Func<double, double>> _dictionary;

        public Invoker()
        {
            CreateOperations();
        }

        public void Compute(string myOperator, double operand)
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

        public void Undo(int levels)
        {
        }

        public void Redo(int levels)
        {
        }
    }
}