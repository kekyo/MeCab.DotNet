@echo off
dotnet pack -p:Configuration=Release -o artifacts MeCab.DotNet\MeCab.DotNet.csproj
