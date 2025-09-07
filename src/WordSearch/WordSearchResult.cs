namespace WordSearch;

/// <summary>
/// The word search result.
/// </summary>
/// <param name="Found">Whether the word is found in the puzzle.</param>
/// <param name="Position">The position of the first character of the search word.</param>
/// <param name="Direction">The direction of the found word.</param>
public readonly record struct WordSearchResult(bool Found, Position? Position = null, Direction? Direction = null);
