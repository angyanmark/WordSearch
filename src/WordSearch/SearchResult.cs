namespace WordSearch;

/// <summary>
/// The search result.
/// </summary>
/// <param name="Found">Whether the character is found in the puzzle.</param>
/// <param name="Direction">The direction of the search.</param>
internal readonly record struct SearchResult(bool Found, Direction? Direction = null);
