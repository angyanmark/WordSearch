namespace WordSearch.Tests;

[TestClass]
public sealed class WordSearchTests
{
    [TestMethod]
    [DynamicData(nameof(TestCases.Cases), typeof(TestCases))]
    public void TestPuzzle(char[,] grid, IEnumerable<string> words, IEnumerable<WordSearchResult> expectedResults) =>
        Assert.IsTrue(expectedResults.SequenceEqual(WordSearcher.Search(grid, words)));
}
