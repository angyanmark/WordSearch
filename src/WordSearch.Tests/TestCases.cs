namespace WordSearch.Tests;

using static TestPuzzles;

internal static class TestCases
{
    public static IEnumerable<(char[,], IEnumerable<string>, IEnumerable<WordSearchResult>)> Cases =>
    [
        (Grid0X0, WordsEmpty, []),
        (Grid0X0, Words0X0Invalid, [new(false), new(false)]),
        (Grid0X0, WordsEmptyString, [new(false)]),
        (Grid0X3, WordsSingle, [new(false)]),
        (Grid3X0, WordsSingle, [new(false)]),
        (Grid1X1, Words1X1Valid, [new(true, new(0, 0))]),
        (Grid1X1, Words1X1Invalid, [new(false), new(false), new(false)]),
        (Grid1X1, WordsEmptyString, [new(true, new(0, 0))]),
        (Grid1X3, Words1X3Valid,
        [
            new(true, new(0, 0)), new(true, new(0, 0), new(0, 1)), new(true, new(0, 0), new(0, 1)),
            new(true, new(0, 1)), new(true, new(0, 1), new(0, -1)), new(true, new(0, 1), new(0, 1)),
            new(true, new(0, 2)), new(true, new(0, 2), new(0, -1)), new(true, new(0, 2), new(0, -1)),
        ]),
        (Grid1X3, Words1X3Invalid, [new(false), new(false), new(false), new(false), new(false), new(false)]),
        (Grid3X1, Words3X1Valid,
        [
            new(true, new(0, 0)), new(true, new(0, 0), new(1, 0)), new(true, new(0, 0), new(1, 0)),
            new(true, new(1, 0)), new(true, new(1, 0), new(-1, 0)), new(true, new(1, 0), new(1, 0)),
            new(true, new(2, 0)), new(true, new(2, 0), new(-1, 0)), new(true, new(2, 0), new(-1, 0)),
        ]),
        (Grid3X1, Words3X1Invalid, [new(false), new(false), new(false), new(false), new(false), new(false)]),
        (Grid3X3, Words3X3Valid,
        [
            new(true, new(0, 0)), new(true, new(0, 0), new(0, 1)), new(true, new(0, 0), new(0, 1)),
            new(true, new(0, 0), new(1, 0)), new(true, new(0, 0), new(1, 0)), new(true, new(0, 0), new(1, 1)), new(true, new(0, 0), new(1, 1)),
            new(true, new(0, 1)), new(true, new(0, 1), new(0, -1)), new(true, new(0, 1), new(1, -1)), new(true, new(0, 1), new(1, 0)), new(true, new(0, 1), new(1, 0)), new(true, new(0, 1), new(1, 1)), new(true, new(0, 1), new(0, 1)),
            new(true, new(0, 2)), new(true, new(0, 2), new(0, -1)), new(true, new(0, 2), new(0, -1)), new(true, new(0, 2), new(1, -1)), new(true, new(0, 2), new(1, -1)), new(true, new(0, 2), new(1, 0)), new(true, new(0, 2), new(1, 0)),
            new(true, new(1, 0)), new(true, new(1, 0), new(-1, 0)), new(true, new(1, 0), new(-1, 1)), new(true, new(1, 0), new(0, 1)), new(true, new(1, 0), new(0, 1)), new(true, new(1, 0), new(1, 1)), new(true, new(1, 0), new(1, 0)),
            new(true, new(1, 1)), new(true, new(1, 1), new(-1, -1)), new(true, new(1, 1), new(-1, 0)), new(true, new(1, 1), new(-1, 1)), new(true, new(1, 1), new(0, 1)), new(true, new(1, 1), new(1, 1)), new(true, new(1, 1), new(1, 0)), new(true, new(1, 1), new(1, -1)), new(true, new(1, 1), new(0, -1)),
            new(true, new(1, 2)), new(true, new(1, 2), new(-1, -1)), new(true, new(1, 2), new(-1, 0)), new(true, new(1, 2), new(1, 0)), new(true, new(1, 2), new(1, -1)), new(true, new(1, 2), new(0, -1)), new(true, new(1, 2), new(0, -1)),
            new(true, new(2, 0)), new(true, new(2, 0), new(-1, 0)), new(true, new(2, 0), new(-1, 0)), new(true, new(2, 0), new(-1, 1)), new(true, new(2, 0), new(-1, 1)), new(true, new(2, 0), new(0, 1)), new(true, new(2, 0), new(0, 1)),
            new(true, new(2, 1)), new(true, new(2, 1), new(-1, -1)), new(true, new(2, 1), new(-1, 0)), new(true, new(2, 1), new(-1, 0)), new(true, new(2, 1), new(-1, 1)), new(true, new(2, 1), new(0, -1)), new(true, new(2, 1), new(0, 1)),
            new(true, new(2, 2)), new(true, new(2, 2), new(0, -1)), new(true, new(2, 2), new(0, -1)), new(true, new(2, 2), new(-1, -1)), new(true, new(2, 2), new(-1, -1)), new(true, new(2, 2), new(-1, 0)), new(true, new(2, 2), new(-1, 0)),
        ]),
        (Grid3X3, WordsEmpty, []),
        (Grid3X3, Words3X3Invalid, [new(false), new(false), new(false), new(false), new(false), new(false), new(false), new(false), new(false)]),
        (Grid1X3, WordsDuplicates,
        [
            new(true, new(0, 0)), new(true, new(0, 0)), new(true, new(0, 0), new(0, 1)),
        ]),
        (Grid3X3Repeated, WordsRepeated,
        [
            new(true, new(0, 0), new(0, 1)), new(true, new(0, 0), new(0, 1)),
            new(false),
        ]),
    ];
}
