@echo off
msbuild -t:Pack -p:Configuration=Release MeCab.DotNet\MeCab.DotNet.csproj
