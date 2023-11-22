#!/bin/bash

echo ""
echo "==========================================================="
echo "Build MeCab.DotNet"
echo ""

dotnet build -p:Configuration=Release -p:Platform="Any CPU" -p:RestoreNoCache=True MeCab.DotNet.sln
dotnet pack -p:Configuration=Release -p:Platform="Any CPU" -p:RestoreNoCache=True -o artifacts MeCab.DotNet.sln
