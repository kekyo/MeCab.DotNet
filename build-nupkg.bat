@echo off
;dotnet pack -p:Configuration=Release -o artifacts MeCab.DotNet\MeCab.DotNet.csproj
msbuild -t:Pack -p:Configuration=Release MeCab.DotNet\MeCab.DotNet.csproj