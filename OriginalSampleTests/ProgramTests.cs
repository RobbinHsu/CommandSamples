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
        public void CheckLength()
        {
            Action lengthData = FakeDataSource.CreateLengthData;
            var actual = Program.Command(lengthData);

            var expected = new List<CheckResult>()
            {
                new CheckResult() {Source = "96500000000002015092919830912", Result = true},
            };

            expected.ToExpectedObject().ShouldEqual(actual);
        }
    }
}