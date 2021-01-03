using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandSample001
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoker invoker = new Invoker();
            invoker.Compute("+", 50);
            invoker.Compute("-", 25);
            invoker.Compute("*", 20);
            invoker.Compute("/", 4);
            Console.WriteLine("Undo");
            invoker.Undo(3);
            //Console.WriteLine("Redo");
            //invoker.Redo(2);

            Console.ReadLine();
        }
    }
}
