#!/bin/bash
dotnet publish WordSearch/WordSearch.csproj --output artifacts/WordSearch
dotnet publish WordSearch.Cli/WordSearch.Cli.csproj --output artifacts/WordSearch.Cli
dotnet publish WordSearch.Tests/WordSearch.Tests.csproj --output artifacts/WordSearch.Tests --runtime linux-x64
