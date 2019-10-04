# MeCab.DotNet

A morphological analysis engine for .NET Core.

[![NuGet MeCab.DotNet](https://img.shields.io/nuget/v/MeCab.DotNet.svg?style=flat)](https://www.nuget.org/packages/MeCab.DotNet)

# What's this?

["MeCab"](https://github.com/taku910/mecab) is a morphological analysis engine.

["NMeCab"](https://ja.osdn.net/projects/nmecab/) is a re-implementation of MeCab engine on .NET Framework 2.0 managed library, but didn't update long time (looks like suspended...)

["MeCab.DotNet"](https://ja.osdn.net/projects/nmecab/) is a ported of NMeCab on .NET Core 1/2/3 and .NET Frameworks and packed into NuGet format.

# How to use

MeCab.DotNet targetted platforms:
* .NET Core 1/2/3 (Built on .NET Standard 1.0/2.0/2.1)
* .NET Framework 4.0/4.5 or upper.

1. Install from NuGet.
2. Usually you'll use default dictionary named IPADIC, the package will append `dic` folder into your project automatically. But have to declare `MeCabUseDefaultDictionary` property and set value to `False` inside `PropertyGroup` in csproj if you wanna use your own dictionary.
3. Build and run!

# License
Under GPL2, LGPL2.1 derived from NMeCab project.
