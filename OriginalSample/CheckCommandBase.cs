namespace OriginalSample
{
    public abstract class CheckCommandBase
    {
        protected IFormatChecker Checker { get; private set; }

        protected CheckCommandBase(IFormatChecker checker)
        {
            Checker = checker;
        }

        public abstract bool Execute(string source);
    }
}