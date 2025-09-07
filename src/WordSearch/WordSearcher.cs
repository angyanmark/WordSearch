namespace WordSearch;

/// <summary>
/// A class for solving word search puzzles.
/// </summary>
public static class WordSearcher
{
    private static readonly Direction[] Directions =
    [
        new(-1, -1),
        new(-1, 0),
        new(-1, 1),
        new(0, -1),
        new(0, 1),
        new(1, -1),
        new(1, 0),
        new(1, 1),
    ];

    /// <summary>
    /// Searches words in the character grid.
    /// </summary>
    /// <param name="grid">A grid that contains the characters of the puzzle.</param>
    /// <param name="words">The search words.</param>
    /// <returns>The results of the search.</returns>
    public static IEnumerable<WordSearchResult> Search(char[,] grid, IEnumerable<string> words) =>
        words.Select(word => Search(grid, word));

    /// <summary>
    /// Searches a specific word in the character grid.
    /// </summary>
    /// <param name="grid">A grid that contains the characters of the puzzle.</param>
    /// <param name="word">The search word.</param>
    /// <returns>The result of the search.</returns>
    public static WordSearchResult Search(char[,] grid, ReadOnlySpan<char> word)
    {
        for (var row = 0; row < grid.GetLength(0); row++)
        {
            for (var col = 0; col < grid.GetLength(1); col++)
            {
                var search = SearchWord(grid, row, col, word, 0);
                if (search.Found)
                {
                    return new(true, new(row, col), search.Direction);
                }
            }
        }

        return new(false);
    }

    private static SearchResult SearchWord(
        char[,] grid,
        int row,
        int col,
        ReadOnlySpan<char> word,
        int index,
        Direction? direction = null)
    {
        if (index == word.Length) return new(true, direction); // End of word.
        if (row < 0 || col < 0 || row >= grid.GetLength(0) || col >= grid.GetLength(1)) return new(false); // Out of bounds.
        if (grid[row, col] != word[index]) return new(false); // Wrong character.

        if (direction.HasValue)
        {
            var search = SearchWord(grid, row + direction.Value.Row, col + direction.Value.Column, word, index + 1, direction);
            if (search.Found)
            {
                return new(true, search.Direction);
            }
        }
        else
        {
            for (var i = 0; i < Directions.Length; i++)
            {
                var search = SearchWord(grid, row + Directions[i].Row, col + Directions[i].Column, word, index + 1, Directions[i]);
                if (search.Found)
                {
                    return new(true, search.Direction);
                }
            }
        }

        return new(false);
    }
}
