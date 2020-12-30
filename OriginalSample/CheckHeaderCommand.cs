namespace OriginalSample
{
    public class CheckHeaderCommand : CheckCommandBase
    {
        private readonly FormatChecker _formatChecker;

        public CheckHeaderCommand(FormatChecker checker) : base(checker)
        {
            _formatChecker = checker;
        }

        public override bool Execute(string source)
        {
            return _formatChecker.CheckHeader(source);
        }
    }
}