namespace WordSearch.Tests;

public class WordSearchTests
{
    private static readonly char[,] Grid3X3 =
    {
        { 'a', 'b', 'c' },
        { 'd', 'e', 'f' },
        { 'g', 'h', 'i' },
    };
    
    private static readonly HashSet<string> Words3X3Valid =
    [
        "a", "ab", "abc", "ad", "adg", "ae", "aei", 
        "b", "ba", "bd", "be", "beh", "bf", "bc",
        "c", "cb", "cba", "ce", "ceg", "cf", "cfi",
        "d", "da", "db", "de", "def", "dh", "dg",
        "e", "ea", "eb", "ec", "ef", "ei", "eh", "eg", "ed",
        "f", "fb", "fc", "fi", "fh", "fe", "fed",
        "g", "gd", "gda", "ge", "gec", "gh", "ghi",
        "h", "hd", "he", "heb", "hf", "hg", "hi",
        "i", "ih", "ihg", "ie", "iea", "if", "ifc",
    ];

    public static (char[,] grid, HashSet<string> words) DataSource3X3Valid() =>
        (Grid3X3, Words3X3Valid);

    [Test]
    [MethodDataSource(nameof(DataSource3X3Valid))]
    public async Task Test_Valid(char[,] grid, HashSet<string> words)
    {
        var results = WordSearcher.SearchWords(grid, words);
        foreach (var result in results)
        {
            await Assert.That(result.Found).IsTrue();
        }
    }
}
