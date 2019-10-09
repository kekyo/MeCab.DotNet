@echo off
rem dotnet pack -p:Configuration=Release -o artifacts MeCab.DotNet\MeCab.DotNet.csproj
msbuild -t:pack -p:Configuration=Release -p:PackageOutputPath=..\artifacts MeCab.DotNet\MeCab.DotNet.csproj
