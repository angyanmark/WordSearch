namespace WordSearch;

/// <summary>
/// A position on the two-dimensional grid.
/// </summary>
/// <param name="Row">Row number. 0-based.</param>
/// <param name="Column">Column number. 0-based.</param>
public readonly record struct Position(int Row, int Column);
