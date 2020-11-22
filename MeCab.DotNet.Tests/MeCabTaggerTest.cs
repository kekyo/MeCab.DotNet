using System;
using System.IO;
using NUnit.Framework;

namespace MeCab
{
    [TestFixture]
    public class MeCabTaggerTest
    {
        /// <summary>
        /// 複数個のインスタンスを作っても例外が発生しないことの確認。
        /// 従来、MemoryMappedFileに起因して、辞書が使用中という旨のIOExceptionが発生していた。
        /// net45はMemoryMappedFileを利用するので確認可能。netcoreapp2.1は元々利用しないので従来から成功する。
        /// </summary>
        [Test]
        public void CreateMulti()
        {
            // In unit test context, the current folder path is set unstable.
            var parameter = new MeCabParam
            {
                DicDir = Path.Combine(
                    Path.GetDirectoryName(this.GetType().Assembly.Location),
                    "dic")
            };

            using var tagger1 = MeCabTagger.Create(parameter);
            using var tagger2 = MeCabTagger.Create(parameter);

            GC.KeepAlive(tagger1);
            GC.KeepAlive(tagger2);
        }
    }
}
