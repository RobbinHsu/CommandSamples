using NUnit.Framework;
using OriginalSample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExpectedObjects;
using FakeDataLibrary;

namespace OriginalSample.Tests
{
    [TestFixture()]
    public class ProgramTests
    {
        private List<CheckResult> _actual;
        private CommandSample _commandSample;

        [SetUp]
        public void Setup()
        {
            _commandSample = new CommandSample();
        }


        [Test()]
        public void CheckFirstDateTime()
        {
            Action lengthData = FakeDataSource.CreateFirstDateTime;
            _actual = _commandSample.Command(lengthData);

            var expected = new List<CheckResult>()
            {
                new CheckResult() {Source = "96500000000000000000000000000", Result = false},
            };

            expected.ToExpectedObject().ShouldEqual(_actual);
        }

        [Test()]
        public void CheckHeader()
        {
            Action headerData = FakeDataSource.CreateHeaderData;
            _actual = _commandSample.Command(headerData);

            var expected = new List<CheckResult>()
            {
                new CheckResult() {Source = "00000000000002015092919830912", Result = false},
            };

            expected.ToExpectedObject().ShouldEqual(_actual);
        }

        [Test()]
        public void CheckLength()
        {
            Action lengthData = FakeDataSource.CreateLengthData;
            _actual = _commandSample.Command(lengthData);

            var expected = new List<CheckResult>()
            {
                new CheckResult() {Source = "96500000000002015092919830912", Result = true},
            };

            expected.ToExpectedObject().ShouldEqual(_actual);
        }
    }
}