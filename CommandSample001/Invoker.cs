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

        public Invoker()
        {
        }

        public void Compute(string myOperator, double operand)
        {
            _currentValue = _currentValue + operand;
            Console.WriteLine($"{myOperator} {operand} 之後目前的值為 {_currentValue}");
        }

        public void Undo(int levels)
        {
        }

        public void Redo(int levels)
        {
        }
    }
}