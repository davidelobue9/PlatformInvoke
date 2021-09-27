using System;
using System.Collections.Generic;
using System.Text;

namespace PlatformInvoke
{
    public class Kernel32Exception : Exception
    {
        public int ErrorCode { get; }

        public Kernel32Exception(string message, int errorCode) : base(message)
        {
            ErrorCode = errorCode;
        }

    }
}
