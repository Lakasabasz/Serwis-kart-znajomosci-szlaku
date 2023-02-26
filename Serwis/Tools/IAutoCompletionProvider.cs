namespace Serwis.Tools;

public interface IAutoCompletionProvider
{
    IEnumerable<object> GetCompletions(string prefix, int maxOccurrences);
}