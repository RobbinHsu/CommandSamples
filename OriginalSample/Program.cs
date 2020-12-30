using FakeDataLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OriginalSample
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            var results = Command(FakeDataSource.CreateData);

            foreach (var item in results)
            {
                Console.WriteLine($"Source : {item.Source} , Result is {item.Result}");
            }

            Console.ReadLine();
        }

        public static List<CheckResult> Command(Action createData)
        {
            var checker = new FormatChecker();
            var results = new List<CheckResult>();

            foreach (var item in FakeDataSource.Data(createData))
            {
                results.Add(checker.Check(item));
            }

            return results;
        }
    }
}