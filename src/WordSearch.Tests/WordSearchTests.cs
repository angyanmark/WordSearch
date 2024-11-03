namespace WordSearch.Tests;

using static TestPuzzles;

public class WordSearchTests
{
    public static (char[,], HashSet<string>, bool) _0X0WithEmpty() => (Grid0X0, WordsEmpty, true);
    public static (char[,], HashSet<string>, bool) _0X0Invalid() => (Grid0X0, Words0X0Invalid, false);
    public static (char[,], HashSet<string>, bool) _1X1Valid() => (Grid1X1, Words1X1Valid, true);
    public static (char[,], HashSet<string>, bool) _1X1Invalid() => (Grid1X1, Words1X1Invalid, false);
    public static (char[,], HashSet<string>, bool) _1X3Valid() => (Grid1X3, Words1X3Valid, true);
    public static (char[,], HashSet<string>, bool) _1X3Invalid() => (Grid1X3, Words1X3Invalid, false);
    public static (char[,], HashSet<string>, bool) _3X1Valid() => (Grid3X1, Words3X1Valid, true);
    public static (char[,], HashSet<string>, bool) _3X1Invalid() => (Grid3X1, Words3X1Invalid, false);
    public static (char[,], HashSet<string>, bool) _3X3Valid() => (Grid3X3, Words3X3Valid, true);
    public static (char[,], HashSet<string>, bool) _3X3WithEmpty() => (Grid3X3, WordsEmpty, true);
    public static (char[,], HashSet<string>, bool) _3X3Invalid() => (Grid3X3, Words3X3Invalid, false);

    [Test]
    [MethodDataSource(nameof(_0X0WithEmpty))]
    [MethodDataSource(nameof(_0X0Invalid))]
    [MethodDataSource(nameof(_1X1Valid))]
    [MethodDataSource(nameof(_1X1Invalid))]
    [MethodDataSource(nameof(_1X3Valid))]
    [MethodDataSource(nameof(_1X3Invalid))]
    [MethodDataSource(nameof(_3X1Valid))]
    [MethodDataSource(nameof(_3X1Invalid))]
    [MethodDataSource(nameof(_3X3Valid))]
    [MethodDataSource(nameof(_3X3WithEmpty))]
    [MethodDataSource(nameof(_3X3Invalid))]
    public async Task TestPuzzles(char[,] grid, HashSet<string> words, bool shouldBeFound)
    {
        var results = WordSearcher.SearchWords(grid, words);
        foreach (var result in results)
        {
            await Assert.That(result.Found).IsEqualTo(shouldBeFound);
        }
    }
}
