namespace Serwis.Tools;

public class AutoCompletionTest: IAutoCompletionProvider
{
    public IEnumerable<object> GetCompletions(string prefix, int maxOccurrences)
    {
        return new[] { "a", "aa", "b", "ab", "ba", "bb" }
            .Where(x => x.StartsWith(prefix) && prefix.Length > 0)
            .Take(maxOccurrences);
    }
}