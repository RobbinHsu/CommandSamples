using FakeDataLibrary;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OriginalSample
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            var commandSample = new CommandSample();
            var results = commandSample.Command(FakeDataSource.CreateData);

            foreach (var item in results)
            {
                Console.WriteLine($"Source : {item.Source} , Result is {item.Result}");
            }

            Console.ReadLine();
        }
    }
}