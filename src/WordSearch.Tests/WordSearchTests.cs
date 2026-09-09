namespace WordSearch.Tests;

using static TestPuzzles;

[TestClass]
public sealed class WordSearchTests
{
    public static IEnumerable<(char[,], IEnumerable<string>, bool)> TestCases =>
    [
        (Grid0X0, WordsEmpty, true),
        (Grid0X0, Words0X0Invalid, false),
        (Grid1X1, Words1X1Valid, true),
        (Grid1X1, Words1X1Invalid, false),
        (Grid1X3, Words1X3Valid, true),
        (Grid1X3, Words1X3Invalid, false),
        (Grid3X1, Words3X1Valid, true),
        (Grid3X1, Words3X1Invalid, false),
        (Grid3X3, Words3X3Valid, true),
        (Grid3X3, WordsEmpty, true),
        (Grid3X3, Words3X3Invalid, false),
    ];

    [TestMethod]
    [DynamicData(nameof(TestCases))]
    public void TestPuzzle(char[,] grid, IEnumerable<string> words, bool shouldBeFound) =>
        Assert.IsTrue(WordSearcher.Search(grid, words).All(result => result.Found == shouldBeFound));
}
