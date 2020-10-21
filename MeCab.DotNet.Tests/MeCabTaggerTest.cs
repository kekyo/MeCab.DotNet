using System;
using NUnit.Framework;

namespace MeCab
{
    [TestFixture]
    public class MeCabTaggerTest
    {
#if NET45
        /// <summary>
        /// 複数個のインスタンスを作っても例外が発生しないことの確認。
        /// 従来、MemoryMappedFileに起因して、辞書が使用中という旨のIOExceptionが発生していた。
        /// </summary>
        [Test]
        public void CreateMulti()
        {
            using var tagger1 = MeCabTagger.Create();
            using var tagger2 = MeCabTagger.Create();

            GC.KeepAlive(tagger1);
            GC.KeepAlive(tagger2);
        }
#endif
    }
}
