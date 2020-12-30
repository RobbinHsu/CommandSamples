namespace OriginalSample
{
    public class CheckHeaderCommand : CheckCommandBase
    {
        private readonly IFormatChecker _formatChecker;

        public CheckHeaderCommand(IFormatChecker checker) : base(checker)
        {
            _formatChecker = checker;
        }

        public override bool Execute(string source)
        {
            return _formatChecker.CheckHeader(source);
        }
    }
}