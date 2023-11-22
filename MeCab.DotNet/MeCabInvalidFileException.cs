//  MeCab -- Yet Another Part-of-Speech and Morphological Analyzer
//
//  Copyright(C) 2001-2006 Taku Kudo <taku@chasen.org>
//  Copyright(C) 2004-2006 Nippon Telegraph and Telephone Corporation
using System;
using System.Text;

namespace MeCab
{
#if NETFRAMEWORK || NETSTANDARD2_0_OR_GREATER || NETCOREAPP
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
#endif
    public class MeCabInvalidFileException : MeCabException
    {
        public string FileName { get; private set; }

        public override string Message
        {
            get
            {
                StringBuilder os = new StringBuilder();
                os.Append(base.Message);
                if (this.FileName != null) os.AppendFormat("[FileName:{0}]", this.FileName);
                return os.ToString();
            }
        }

        public MeCabInvalidFileException(string message, string fileName)
            : base(message)
        {
            this.FileName = fileName;
        }

#if NETFRAMEWORK || NETSTANDARD2_0_OR_GREATER || NETCOREAPP
#if NET8_0_OR_GREATER
        [Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.")]
#endif
        public MeCabInvalidFileException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
            this.FileName = info.GetString("FileName");
        }

#if !NET5_0_OR_GREATER
        [SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.SerializationFormatter)]
#endif
#if NET8_0_OR_GREATER
        [Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.")]
#endif
        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            base.GetObjectData(info, context);
            info.AddValue("FileName", this.FileName);
        }
#endif
    }
}
