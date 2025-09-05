namespace WordSearch;

/// <summary>
/// A direction on the two-dimensional grid.
/// </summary>
/// <param name="X">X-axis.</param>
/// <param name="Y">Y-axis.</param>
internal readonly record struct Direction(short X, short Y);
