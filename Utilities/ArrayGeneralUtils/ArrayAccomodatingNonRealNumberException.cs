using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilExceptions
{
    class ArrayAccomodatingNonRealNumberException : Exception
    {
        public ArrayAccomodatingNonRealNumberException() : base("Array must contain real numbers")
        {
        }
    }
}

