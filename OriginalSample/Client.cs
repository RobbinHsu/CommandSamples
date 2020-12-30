using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OriginalSample
{
    public class Client
    {
        public CheckResult CreateInvoker(string source)
        {
            var checker = new FormatChecker();

            var invoker = new Invoker();
            invoker.AddCommand(new CheckHeaderCommand(checker).Execute);
            invoker.AddCommand(new CheckFirstDateTimeCommand(checker).Execute);
            invoker.AddCommand(new CheckSecondDateTimeCommand(checker).Execute);

            return invoker.CheckResult(source);
        }
    }
}