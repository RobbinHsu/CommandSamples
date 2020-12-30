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

        [SetUp]
        public void Setup()
        {
            _invoker = new FakeInvoker();
        }

        [Test()]
        public void AddTest()
        {
            _invoker.Compute("+", 50);
            Assert.AreEqual(50, _invoker.GetValue());
        }

        [Test()]
        public void DivisionTest()
        {
            _invoker.Compute("+", 40);
            _invoker.Compute("/", 5);
            Assert.AreEqual(8, _invoker.GetValue());
        }

        [Test()]
        public void MultiplicationTest()
        {
            _invoker.Compute("+", 40);
            _invoker.Compute("-", 25);
            _invoker.Compute("*", 25);
            Assert.AreEqual(375, _invoker.GetValue());
        }

        [Test()]
        public void SubtractTest()
        {
            _invoker.Compute("+", 40);
            _invoker.Compute("-", 25);
            Assert.AreEqual(15, _invoker.GetValue());
        }
    }

    public class FakeInvoker : Invoker
    {
        public double GetValue()
        {
            return _currentValue;
        }
    }
}