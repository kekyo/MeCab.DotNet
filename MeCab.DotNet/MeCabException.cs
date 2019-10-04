//  MeCab -- Yet Another Part-of-Speech and Morphological Analyzer
//
//  Copyright(C) 2001-2006 Taku Kudo <taku@chasen.org>
//  Copyright(C) 2004-2006 Nippon Telegraph and Telephone Corporation
using System;

namespace NMeCab
{
#if !NETSTANDARD1_3
    using System.Runtime.Serialization;

    [Serializable]
#endif
    public class MeCabException : Exception
    {
        public MeCabException(string message)
            : base(message)
        { }

        public MeCabException(string message, Exception ex)
            : base(message, ex)
        { }

#if !NETSTANDARD1_3
        public MeCabException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        { }
#endif
    }
}
