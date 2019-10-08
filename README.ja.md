# MeCab.DotNet

日本語形態素解析エンジン for .NET Core.

![MeCab.DotNet](Images/MeCab.DotNet-120.png)

[![NuGet MeCab.DotNet](https://img.shields.io/nuget/v/MeCab.DotNet.svg?style=flat)](https://www.nuget.org/packages/MeCab.DotNet)

[English language is here. (英語はこちら)](README.md)

# これは何？

["MeCab"](https://github.com/taku910/mecab) は、日本語形態素解析エンジンのプロジェクトです。

["NMeCab"](https://ja.osdn.net/projects/nmecab/) は、上記MeCabを、.NET Framework 2.0のマネージライブラリとして実装し直したものです。ただ、もう更新されていないようです...

"MeCab.DotNet" （このプロジェクト）は、上記NMeCabを最新の.NET Core 1/2/3と.NET Frameworkで使えるように移植し、NuGetのパッケージに固めて使いやすくしたものです。

形態素解析とは、任意の日本語の文書を入力として、その文字や単語が日本語文法的に何であるのかを解析するというものです。これを使うと、自由に書かれた日本語の文脈に沿って、文書文字列を機械的に解析することが出来るようになります。
サンプルコードを参照すれば、おおよその使い方が理解できると思います。

# 使い方

MeCab.DotNetのターゲットプラットフォームです:
* .NET Core 1/2/3 (実際には.NET Standard 1.3/2.0/2.1に適合します)
* .NET Framework 4.0/4.5かそれ以上

NMeCabからの変更点:
* より幅広いプラットフォームに対応し、PCLや.NET Framework 3.5以下は切り捨て。
* 名前空間の競合を避けるため、`NMeCab`を`MeCab`に変えています。
* App.configベースの構成を削除 （辞書フォルダ指定などが必要な場合は、`MeCabParam`クラスを使用します）
* 若干のユーティリティメソッドの追加。

導入の方法:
1. [NuGetから"MeCab.DotNet"をインストール](https://www.nuget.org/packages/MeCab.DotNet).
2. 大抵の場合、デフォルトのIPADICという辞書（自動的に`dic`フォルダに追加されます）を使って、無難な解析を行うことが出来ます（つまり、辞書ファイルについて何もしなくてもOK）。しかし、もしカスタムの辞書を使いたい場合は、csproj内の`PropertyGroup`に、`MeCabUseDefaultDictionary`を追加してその値を`False`にしてください。カスタム辞書を`dic`フォルダに追加して使用できるようになります。
3. ビルドして実行します！

# サンプルコード

```csharp
using System;
using MeCab;

namespace ConsoleApp
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            var sentence = "行く川のながれは絶えずして、しかも本の水にあらず。";

            var parameter = new MeCabParam();
            var tagger = MeCabTagger.Create(parameter);

            foreach (var node in tagger.ParseToNodes(sentence))
            {
                if (node.CharType > 0)
                {
                    var features = node.Feature.Split(',');
                    var displayFeatures = string.Join(", ", features);

                    Console.WriteLine($"{node.Surface}\t{displayFeatures}");
                }
            }
        }
    }
}
```

結果:

```
行く    動詞, 自立, *, *, 五段・カ行促音便, 基本形, 行く, イク, イク
川      名詞, 一般, *, *, *, *, 川, カワ, カワ
の      助詞, 連体化, *, *, *, *, の, ノ, ノ
ながれ  動詞, 自立, *, *, 一段, 連用形, ながれる, ナガレ, ナガレ
は      助詞, 係助詞, *, *, *, *, は, ハ, ワ
絶えず  副詞, 一般, *, *, *, *, 絶えず, タエズ, タエズ
し      動詞, 自立, *, *, サ変・スル, 連用形, する, シ, シ
て      助詞, 接続助詞, *, *, *, *, て, テ, テ
、      記号, 読点, *, *, *, *, 、, 、, 、
しかも  接続詞, *, *, *, *, *, しかも, シカモ, シカモ
本      名詞, 一般, *, *, *, *, 本, ホン, ホン
の      助詞, 連体化, *, *, *, *, の, ノ, ノ
水      名詞, 一般, *, *, *, *, 水, ミズ, ミズ
に      助詞, 格助詞, 一般, *, *, *, に, ニ, ニ
あら    動詞, 自立, *, *, 五段・ラ行, 未然形, ある, アラ, アラ
ず      助動詞, *, *, *, 特殊・ヌ, 連用ニ接続, ぬ, ズ, ズ
。      記号, 句点, *, *, *, *, 。, 。, 。
```

# ライセンス
GPL2またはLGPL2.1です（NMeCabプロジェクトから引き継いでいます）。
