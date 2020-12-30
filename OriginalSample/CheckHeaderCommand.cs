namespace OriginalSample
{
    public class CheckHeaderCommand
    {
        private readonly FormatChecker _formatChecker = new FormatChecker();

        public CheckHeaderCommand(FormatChecker checker)
        {
            _formatChecker = checker;
        }

        public bool Execute(string source)
        {
            return _formatChecker.CheckHeader(source);
        }
    }
}