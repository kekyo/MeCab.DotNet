//  MeCab -- Yet Another Part-of-Speech and Morphological Analyzer
//
//  Copyright(C) 2001-2006 Taku Kudo <taku@chasen.org>
//  Copyright(C) 2004-2006 Nippon Telegraph and Telephone Corporation
using System;

namespace MeCab
{
#if NETFRAMEWORK || NETSTANDARD2_0_OR_GREATER || NETCOREAPP
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

#if NETFRAMEWORK || NETSTANDARD2_0_OR_GREATER || NETCOREAPP
#if NET8_0_OR_GREATER
        [Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.")]
#endif
        public MeCabException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        { }
#endif
    }
}
