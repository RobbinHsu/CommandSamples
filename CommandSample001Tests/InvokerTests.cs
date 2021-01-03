using NUnit.Framework;
using CommandSample001;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandSample001.Tests
{
    [TestFixture()]
    public class InvokerTests
    {
        private FakeCalculator _calculator;
        private FakeInvoker _invoker;

        [SetUp]
        public void Setup()
        {
            _calculator = new FakeCalculator();
            _invoker = new FakeInvoker(_calculator);
        }

        [Test()]
        public void AddTest()
        {
            GivenOperatorAndValue("+", 50);
            ShouldBeEqual(50);
        }

        [Test()]
        public void DivisionTest()
        {
            GivenOperatorAndValue("+", 40);
            GivenOperatorAndValue("/", 5);
            ShouldBeEqual(8);
        }

        [Test()]
        public void MultiplicationTest()
        {
            GivenOperatorAndValue("+", 40);
            GivenOperatorAndValue("*", 25);
            ShouldBeEqual(1000);
        }

        [Test()]
        public void RedoTest()
        {
            GivenOperatorAndValue("+", 50);
            GivenOperatorAndValue("-", 25);
            GivenOperatorAndValue("*", 20);
            GivenOperatorAndValue("/", 4);
            Undo(3);
            Redo(2);
            ShouldBeEqual(500);
        }

        [Test()]
        public void SubtractTest()
        {
            GivenOperatorAndValue("-", 25);
            ShouldBeEqual(-25);
        }

        [Test()]
        public void UndoTest()
        {
            GivenOperatorAndValue("+", 40);
            GivenOperatorAndValue("*", 2);
            Undo(2);
            ShouldBeEqual(0);
        }

        private void Redo(int levels)
        {
            _invoker.Redo(levels);
        }

        private void Undo(int levels)
        {
            _invoker.Undo(levels);
        }

        private void GivenOperatorAndValue(string @operator, int operand)
        {
            _invoker.Compute(@operator, operand);
        }

        private void ShouldBeEqual(int expected)
        {
            Assert.AreEqual(expected, _calculator.GetValue());
        }
    }

    public class FakeInvoker : Invoker
    {
        public FakeInvoker(Calculator calculator)
        {
            _calculator = calculator;
        }
    }

    public class FakeCalculator : Calculator
    {
        public double GetValue()
        {
            return _currentValue;
        }
    }
}