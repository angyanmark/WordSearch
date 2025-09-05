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
                if (SearchWord(grid, row, col, word, 0))
                {
                    return new(true, row, col);
                }
            }
        }

        return new(false);
    }

    private static bool SearchWord(
        char[,] grid,
        int row,
        int col,
        ReadOnlySpan<char> word,
        int index,
        Direction? direction = null)
    {
        if (index == word.Length) return true; // End of word.
        if (row < 0 || col < 0 || row >= grid.GetLength(0) || col >= grid.GetLength(1)) return false; // Out of bounds.
        if (grid[row, col] != word[index]) return false; // Wrong character.

        if (direction.HasValue)
        {
            if (SearchWord(grid, row + direction.Value.X, col + direction.Value.Y, word, index + 1, direction))
            {
                return true;
            }
        }
        else
        {
            for (var i = 0; i < Directions.Length; i++)
            {
                if (SearchWord(grid, row + Directions[i].X, col + Directions[i].Y, word, index + 1, Directions[i]))
                {
                    return true;
                }
            }
        }

        return false;
    }
}
