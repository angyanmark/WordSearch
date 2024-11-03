namespace WordSearch;

/// <summary>
/// An object containing the word search result.
/// </summary>
/// <param name="Found">Whether the word is found in the puzzle.</param>
/// <param name="Row">The row of the first character of the search word. 0-based.</param>
/// <param name="Column">The column of the first character of the search word. 0-based.</param>
public readonly record struct WordSearchResult(bool Found, int? Row = null, int? Column = null);
