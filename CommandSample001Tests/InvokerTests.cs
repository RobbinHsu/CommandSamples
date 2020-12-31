using NUnit.Framework;
using CommandSample002;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandSample002.Tests
{
    [TestFixture()]
    public class InvokerTests
    {
        private FakeInvoker _invoker;
        private FakeCalculator _calculator;

        [SetUp]
        public void Setup()
        {
            _calculator = new FakeCalculator();
            _invoker = new FakeInvoker(_calculator);
        }

        [Test()]
        public void AddTest()
        {
            _invoker.Compute("+", 50);
            Assert.AreEqual(50, _calculator.GetValue());
        }

        [Test()]
        public void DivisionTest()
        {
            _invoker.Compute("+", 40);
            _invoker.Compute("/", 5);
            Assert.AreEqual(8, _calculator.GetValue());
        }

        [Test()]
        public void MultiplicationTest()
        {
            _invoker.Compute("+", 40);
            _invoker.Compute("-", 25);
            _invoker.Compute("*", 25);
            Assert.AreEqual(375, _calculator.GetValue());
        }

        [Test()]
        public void SubtractTest()
        {
            _invoker.Compute("+", 40);
            _invoker.Compute("-", 25);
            Assert.AreEqual(15, _calculator.GetValue());
        }

        [Test()]
        public void UndoTest()
        {
            _invoker.Compute("+", 40);
            _invoker.Undo(1);
            Assert.AreEqual(0, _calculator.GetValue());
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