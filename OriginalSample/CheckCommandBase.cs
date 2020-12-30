namespace OriginalSample
{
    public abstract class CheckCommandBase
    {
        protected FormatChecker Checker { get; private set; }

        protected CheckCommandBase(FormatChecker checker)
        {
            Checker = checker;
        }

        public abstract bool Execute(string source);
    }
}