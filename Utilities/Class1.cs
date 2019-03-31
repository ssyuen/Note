using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities
{

    using static Utilities.ArrayUtils;

    class Class1
    {
        static void Main(string[] args)
        {
            int[] x = { 1, 2, 3, 4 };
            int[] y = { 1, 2, 3, 4, 5, 6 };
            int[] z = { 1, 2, 3 };
            int[] comb = Concat(x, y, z);
            Array.ForEach(comb, e => Console.Write(e + " "));
            Console.Read();
            //Printing out 'comb' results in 1, 2, 3, 4, 1, 2, 3, 4, 5, 6, 1, 2, 3
        }
    }
}
