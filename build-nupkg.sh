#!/bin/sh

dotnet clean -c Release -p:Platform="Any CPU" MeCab.DotNet/MeCab.DotNet.csproj
dotnet restore MeCab.DotNet/MeCab.DotNet.csproj
dotnet build -c Release -p:Platform="Any CPU" MeCab.DotNet/MeCab.DotNet.csproj
dotnet pack -p:Configuration=Release -p:Platform=AnyCPU -o artifacts MeCab.DotNet/MeCab.DotNet.csproj
