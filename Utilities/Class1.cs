using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities
{
    class Class1
    {
        public static void Main(string[] args)
        {
            int[] x = { 1, 2, 3, 4, 5, 6, 7};
            int[] y = x.ShiftEndToLeftManaged(3);

            y.ToList().ForEach(e => Console.Write(e.ToString() + " "));
            Console.Read();
        }
    }
}
