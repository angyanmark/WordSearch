using System.CommandLine;
using WordSearch;

var gridOption = new Option<FileInfo>("--grid", "The character grid of the puzzle.") { IsRequired = true };
var wordsOption = new Option<FileInfo>("--words", "The words to find in the puzzle.") { IsRequired = true };

var rootCommand = new RootCommand("Solve a word search puzzle.");
rootCommand.AddOption(gridOption);
rootCommand.AddOption(wordsOption);
rootCommand.SetHandler(SolvePuzzleAsync, gridOption, wordsOption);

return await rootCommand.InvokeAsync(args);

async static Task SolvePuzzleAsync(FileInfo gridFile, FileInfo wordsFile)
{
    var gridLines = await File.ReadAllLinesAsync(gridFile.FullName);
    var words = await File.ReadAllLinesAsync(wordsFile.FullName);

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
