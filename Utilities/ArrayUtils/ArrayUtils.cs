using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using UtilExceptions;
using System.Linq.Expressions;

namespace Utilities
{
    public static class ArrayUtils
    {
        
        /// <summary>
        /// Concatenates two arrays of the same type together.
        /// </summary>
        /// <param name="array1">The first array to be concatenated</param>
        /// <param name="array2">The second array to be concatenated</param>
        /// <returns>The concatenated array</returns>
        public static T[] Concat <T> (T[] array1, T[] array2)
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
        } //array concat

        /// <summary>
        /// Finds the average of all the elements in the array.
        /// </summary>
        /// <param name="a">The byte type array</param>
        /// <returns>The average of all the elements in the array</returns>
        public static double FindAvg(this byte[] a)
        {
            double sum = 0;
            int denom = a.Length;
            double avg = 0;

            for (int i = 0; i < a.Length; i++)
            {
                sum += a[i];
            }

            return avg = sum / denom;
        }

        /// <summary>
        /// Finds the average of all the elements in the array.
        /// </summary>
        /// <param name="a">The sbyte type array</param>
        /// <returns>The average of all the elements in the array</returns>
        public static double FindAvg(this sbyte[] a)
        {
            double sum = 0;
            int denom = a.Length;
            double avg = 0;

            for (int i = 0; i < a.Length; i++)
            {
                sum += a[i];
            }

            return avg = sum / denom;
        }

        /// <summary>
        /// Finds the average of all the elements in the array.
        /// </summary>
        /// <param name="a">The short type array</param>
        /// <returns>The average of all the elements in the array</returns>
        public static double FindAvg(this short[] a)
        {
            double sum = 0;
            int denom = a.Length;
            double avg = 0;

            for (int i = 0; i < a.Length; i++)
            {
                sum += a[i];
            }

            return avg = sum / denom;
        }

        /// <summary>
        /// Finds the average of all the elements in the array.
        /// </summary>
        /// <param name="a">The ushort type array</param>
        /// <returns>The average of all the elements in the array</returns>
        public static double FindAvg(this ushort[] a)
        {
            double sum = 0;
            int denom = a.Length;
            double avg = 0;

            for (int i = 0; i < a.Length; i++)
            {
                sum += a[i];
            }

            return avg = sum / denom;
        }

        /// <summary>
        /// Finds the average of all the elements in the array.
        /// </summary>
        /// <param name="a">The byte type array</param>
        /// <returns>The average of all the elements in the array</returns>
        public static double FindAvg(this int[] a)
        {
            double sum = 0;
            int denom = a.Length;
            double avg = 0;

            for (int i = 0; i < a.Length; i++)
            {
                sum += a[i];
            }

            return avg = sum / denom;
        }

        /// <summary>
        /// Finds the average of all the elements in the array.
        /// </summary>
        /// <param name="a">The uint type array</param>
        /// <returns>The average of all the elements in the array</returns>
        public static double FindAvg(this uint[] a)
        {
            double sum = 0;
            int denom = a.Length;
            double avg = 0;

            for (int i = 0; i < a.Length; i++)
            {
                sum += a[i];
            }

            return avg = sum / denom;
        }

        /// <summary>
        /// Finds the average of all the elements in the array.
        /// </summary>
        /// <param name="a">The long type array</param>
        /// <returns>The average of all the elements in the array</returns>
        public static double FindAvg(this long[] a)
        {
            double sum = 0;
            int denom = a.Length;
            double avg = 0;

            for (int i = 0; i < a.Length; i++)
            {
                sum += a[i];
            }

            return avg = sum / denom;
        }

        /// <summary>
        /// Finds the average of all the elements in the array.
        /// </summary>
        /// <param name="a">The ulong type array</param>
        /// <returns>The average of all the elements in the array</returns>
        public static double FindAvg(this ulong[] a)
        {
            double sum = 0;
            int denom = a.Length;
            double avg = 0;

            for (int i = 0; i < a.Length; i++)
            {
                sum += a[i];
            }

            return avg = sum / denom;
        }

        /// <summary>
        /// Finds the average of all the elements in the array.
        /// </summary>
        /// <param name="a">The float type array</param>
        /// <returns>The average of all the elements in the array</returns>
        public static double FindAvg(this float[] a)
        {
            double sum = 0;
            int denom = a.Length;
            double avg = 0;

            for (int i = 0; i < a.Length; i++)
            {
                sum += a[i];
            }

            return avg = sum / denom;
        }

        /// <summary>
        /// Finds the average of all the elements in the array.
        /// </summary>
        /// <param name="a">The double type array</param>
        /// <returns>The average of all the elements in the array</returns>
        public static double FindAvg(this double[] a)
        {
            double sum = 0;
            int denom = a.Length;
            double avg = 0;

            for (int i = 0; i < a.Length; i++)
            {
                sum += a[i];
            }

            return avg = sum / denom;
        }

        /// <summary>
        /// Finds the average of all the elements in the array.
        /// </summary>
        /// <param name="a">The char array</param>
        /// <returns>The average of all the elements in the array</returns>
        public static double FindAvg(this char[] a)
        {
            double sum = 0;
            int denom = a.Length;
            double avg = 0;

            for (int i = 0; i < a.Length; i++)
            {
                sum += a[i];
            }

            return avg = sum / denom;
        }

        /// <summary>
        /// Finds the average of all the elements in the List.
        /// </summary>
        /// <param name="l">The List of type byte</param>
        /// <returns>The average of all the elements in the List</returns>
        public static double FindAvg(this List<byte> l)
        {
            double sum = 0;
            int denom = l.Count;
            double avg = 0;

            foreach(byte b in l)
            {
                sum += b;
            }

            return avg = sum / denom;
        }

        /// <summary>
        /// Finds the average of all the elements in the List.
        /// </summary>
        /// <param name="l">The List of type sbyte</param>
        /// <returns>The average of all the elements in the List</returns>
        public static double FindAvg(this List<sbyte> l)
        {
            double sum = 0;
            int denom = l.Count;
            double avg = 0;

            foreach (sbyte sb in l)
            {
                sum += sb;
            }

            return avg = sum / denom;
        }

        /// <summary>
        /// Finds the average of all the elements in the List.
        /// </summary>
        /// <param name="l">The List of type short</param>
        /// <returns>The average of all the elements in the List</returns>
        public static double FindAvg(this List<short> l)
        {
            double sum = 0;
            int denom = l.Count;
            double avg = 0;

            foreach (short s in l)
            {
                sum += s;
            }

            return avg = sum / denom;
        }

        /// <summary>
        /// Finds the average of all the elements in the List.
        /// </summary>
        /// <param name="l">The List of type ushort</param>
        /// <returns>The average of all the elements in the List</returns>
        public static double FindAvg(this List<ushort> l)
        {
            double sum = 0;
            int denom = l.Count;
            double avg = 0;

            foreach (ushort us in l)
            {
                sum += us;
            }

            return avg = sum / denom;
        }

        /// <summary>
        /// Finds the average of all the elements in the List.
        /// </summary>
        /// <param name="l">The List of type int</param>
        /// <returns>The average of all the elements in the List</returns>
        public static double FindAvg(this List<int> l)
        {
            double sum = 0;
            int denom = l.Count;
            double avg = 0;

            foreach (int i in l)
            {
                sum += i;
            }

            return avg = sum / denom;
        }

        /// <summary>
        /// Finds the average of all the elements in the List.
        /// </summary>
        /// <param name="l">The List of type uint</param>
        /// <returns>The average of all the elements in the List</returns>
        public static double FindAvg(this List<uint> l)
        {
            double sum = 0;
            int denom = l.Count;
            double avg = 0;

            foreach (uint ui in l)
            {
                sum += ui;
            }

            return avg = sum / denom;
        }

        /// <summary>
        /// Finds the average of all the elements in the List.
        /// </summary>
        /// <param name="l">The List of type long</param>
        /// <returns>The average of all the elements in the List</returns>
        public static double FindAvg(this List<long> l)
        {
            double sum = 0;
            int denom = l.Count;
            double avg = 0;

            foreach (long lg in l)
            {
                sum += lg;
            }

            return avg = sum / denom;
        }

        /// <summary>
        /// Finds the average of all the elements in the List.
        /// </summary>
        /// <param name="l">The List of type ulong</param>
        /// <returns>The average of all the elements in the List</returns>
        public static double FindAvg(this List<ulong> l)
        {
            double sum = 0;
            int denom = l.Count;
            double avg = 0;

            foreach (ulong ul in l)
            {
                sum += ul;
            }

            return avg = sum / denom;
        }

        /// <summary>
        /// Finds the average of all the elements in the List.
        /// </summary>
        /// <param name="l">The List of type float</param>
        /// <returns>The average of all the elements in the List</returns>
        public static double FindAvg(this List<float> l)
        {
            double sum = 0;
            int denom = l.Count;
            double avg = 0;

            foreach (float f in l)
            {
                sum += f;
            }

            return avg = sum / denom;
        }

        /// <summary>
        /// Finds the average of all the elements in the List.
        /// </summary>
        /// <param name="l">The List of type double</param>
        /// <returns>The average of all the elements in the List</returns>
        public static double FindAvg(this List<double> l)
        {
            double sum = 0;
            int denom = l.Count;
            double avg = 0;

            foreach (double d in l)
            {
                sum += d;
            }

            return avg = sum / denom;
        }

        /// <summary>
        /// Finds the average of all the elements in the List.
        /// </summary>
        /// <param name="l">The List of type char</param>
        /// <returns>The average of all the elements in the List</returns>
        public static double FindAvg(this List<char> l)
        {
            double sum = 0;
            int denom = l.Count;
            double avg = 0;

            foreach (char c in l)
            {
                sum += c;
            }

            return avg = sum / denom;
        }

        //public static double FindAvg<T>(T[] array1)
        //{
        //    if (array1.Equals(typeof(object)))
        //    {
        //        throw new ArrayAccomodatingNonRealNumberException();
        //    }
        //    else
        //    {
        //        double sum = 0;
        //        int denom = array1.Length;
        //        double avg = 0;

        //        for (int i = 0; i < array1.Length; i++)
        //        {
        //            sum += array1[i];
        //        }

        //        return avg = sum / denom;
        //    }
        //}
    }//ArrayUtils
}//Namespace
