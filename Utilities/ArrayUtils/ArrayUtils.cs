using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace Utilities{
    public class ArrayUtils<T>{
        /// <summary>
        /// Concatenates two arrays together.
        /// </summary>
        /// <param name="array1">The array to be concatenated</param>
        /// <param name="array2">The string to be concatenated</param>
        /// <returns>The concatenated array</returns>
        public static T[] Concat(T[] array1, T[] array2)
        {
            T[] array3 = new T[array1.Length + array2.Length];
            for (int i = 0; i < array1.Length; i++)
            {
                array3[i] = array1[i];
            }
            for (int i = 0; i < array2.Length; i++)
            {
                array3[array1.Length + i] = array2[i];
            }
            return array3;
        }//array concat

        public static double FindAvg(T[] array1) 
        {
            if (array1.Equals(typeof(object)))
            {
                Console.WriteLine("Method only works on real number types.");
                return 0;
            }
            else
            {
                double sum = 0;
                int denom = array1.Length;
                double avg = 0;
                for (int i = 0; i < array1.Length; i++)
                {
                    sum += array1[i];
                }

                return avg = sum / denom;
            }
        }
    }
}