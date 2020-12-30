namespace OriginalSample
{
    public interface IFormatChecker
    {
        bool CheckSecondDateTime(string source);
        bool CheckHeader(string source);
        bool CheckFirstDateTime(string source);
    }
}