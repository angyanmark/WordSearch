dotnet publish WordSearch/WordSearch.csproj --configuration Release --output artifacts/WordSearch
dotnet publish WordSearch.Cli/WordSearch.Cli.csproj --configuration Release --output artifacts/WordSearch.Cli
dotnet publish WordSearch.Tests/WordSearch.Tests.csproj --configuration Release --output artifacts/WordSearch.Tests --runtime win-x64
