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
        [Test()]
        public void CheckHeader()
        {
            Action headerData = FakeDataSource.CreateHeaderData;
            var commandSample = new CommandSample();
            var actual = commandSample.Command(headerData);

            var expected = new List<CheckResult>()
            {
                new CheckResult() {Source = "96500000000002015092919830912", Result = true},
                new CheckResult() {Source = "9999889", Result = false},
            };

            expected.ToExpectedObject().ShouldEqual(actual);
        }

        [Test()]
        public void CheckLength()
        {
            Action lengthData = FakeDataSource.CreateLengthData;
            var commandSample = new CommandSample();
            var actual = commandSample.Command(lengthData);

            var expected = new List<CheckResult>()
            {
                new CheckResult() {Source = "96500000000002015092919830912", Result = true},
                new CheckResult() {Source = "9999889", Result = false},
            };

            expected.ToExpectedObject().ShouldEqual(actual);
        }
    }
}