namespace OriginalSample
{
    public class FormatChecker
    {
        public bool CheckHeader(string source)
        {
            if (2 >= source.Length) return false;
            int len = 2 - 0 + 1;
            return source.Substring(0, len).Contains("965");
        }
    }
}