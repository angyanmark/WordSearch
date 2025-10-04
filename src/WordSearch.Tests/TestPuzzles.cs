namespace WordSearch.Tests;

internal static class TestPuzzles
{
    public static readonly char[,] Grid0X0 = { };

    public static readonly char[,] Grid1X1 =
    {
        { 'a' },
    };

    public static readonly char[,] Grid1X3 =
    {
        { 'a', 'b', 'c' },
    };

    public static readonly char[,] Grid3X1 =
    {
        { 'a' },
        { 'b' },
        { 'c' },
    };

    public static readonly char[,] Grid3X3 =
    {
        { 'a', 'b', 'c' },
        { 'd', 'e', 'f' },
        { 'g', 'h', 'i' },
    };

    public static readonly IEnumerable<string> WordsEmpty = [];

    public static readonly IEnumerable<string> Words0X0Invalid =
    [
        "a", "ab",
    ];

    public static readonly IEnumerable<string> Words1X1Valid =
    [
        "a",
    ];

    public static readonly IEnumerable<string> Words1X1Invalid =
    [
        "b", "ba", "bc",
    ];

    public static readonly IEnumerable<string> Words1X3Valid =
    [
        "a", "ab", "abc",
        "b", "ba", "bc",
        "c", "cb", "cba",
    ];

    public static readonly IEnumerable<string> Words1X3Invalid =
    [
        "ac", "ca", "acb", "cab",
        "d",  "da",
    ];

    public static readonly IEnumerable<string> Words3X1Valid =
    [
        "a", "ab", "abc",
        "b", "ba", "bc",
        "c", "cb", "cba",
    ];

    public static readonly IEnumerable<string> Words3X1Invalid =
    [
        "ac", "ca", "acb", "cab",
        "d",  "da",
    ];

    public static readonly IEnumerable<string> Words3X3Valid =
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

    public static readonly IEnumerable<string> Words3X3Invalid =
    [
        "ac", "acb",
        "ai", "aie",
        "ag", "agd",
        "ia", "hb",
        "j",
    ];
}
