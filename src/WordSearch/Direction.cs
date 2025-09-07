namespace WordSearch;

/// <summary>
/// A direction on the two-dimensional grid.
/// </summary>
/// <param name="Row">Row offset of the next character.</param>
/// <param name="Column">Column offset of the next character.</param>
public readonly record struct Direction(int Row, int Column);
