using System.CommandLine;
using WordSearch;

var gridOption = new Option<FileInfo>("--grid") { Description = "The character grid of the puzzle.", Required = true };
var wordsOption = new Option<FileInfo>("--words") { Description = "The words to find in the puzzle.", Required = true };

var rootCommand = new RootCommand("Solve a word search puzzle.");
rootCommand.Options.Add(gridOption);
rootCommand.Options.Add(wordsOption);
rootCommand.SetAction((parseResult, cancellationToken) =>
    SolvePuzzleAsync(
        parseResult.GetRequiredValue(gridOption),
        parseResult.GetRequiredValue(wordsOption),
        cancellationToken));

return await rootCommand.Parse(args).InvokeAsync();

static async Task SolvePuzzleAsync(FileInfo gridFile, FileInfo wordsFile, CancellationToken cancellationToken = default)
{
    var gridLines = await File.ReadAllLinesAsync(gridFile.FullName, cancellationToken);
    var words = await File.ReadAllLinesAsync(wordsFile.FullName, cancellationToken);

    var rows = gridLines.Length;
    var cols = gridLines[0].Length;
    var grid = new char[rows, cols];

    for (var i = 0; i < rows; i++)
    {
        for (var j = 0; j < cols; j++)
        {
            grid[i, j] = gridLines[i][j];
        }
    }

    foreach (var word in words)
    {
        Console.WriteLine($"{WordSearcher.Search(grid, word)} {word}");
    }
}
