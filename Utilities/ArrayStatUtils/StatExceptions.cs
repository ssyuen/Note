using System;

namespace Utilities.UtilExceptions
{
    class InsufficientDataSetException : Exception
    {
        public InsufficientDataSetException(string msg) : base(msg)
        {
        }
    }

    class NoModeException : Exception
    {
        public NoModeException(string msg) : base(msg)
        {
        }
    }
}

