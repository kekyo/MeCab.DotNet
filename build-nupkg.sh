#!/bin/bash

echo ""
echo "==========================================================="
echo "Build MeCab.DotNet"
echo ""

dotnet build -p:Configuration=Release MeCab.DotNet.sln
dotnet pack -p:Configuration=Release -o artifacts MeCab.DotNet.sln
