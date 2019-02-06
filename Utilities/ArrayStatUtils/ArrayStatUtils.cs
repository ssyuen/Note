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
    public static class ArrayStatUtils
    {
        /// <summary>
        /// Finds the average of all the elements in the array.
        /// </summary>
        /// <param name="a">The byte type array</param>
        /// <returns>The average of all the elements in the array</returns>
        public static double Mean(this byte[] a)
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
        public static double Mean(this sbyte[] a)
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
        public static double Mean(this short[] a)
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
        public static double Mean(this ushort[] a)
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
        public static double Mean(this int[] a)
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
        public static double Mean(this uint[] a)
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
        public static double Mean(this long[] a)
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
        public static double Mean(this ulong[] a)
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
        public static double Mean(this float[] a)
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
        public static double Mean(this double[] a)
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
        public static double Mean(this char[] a)
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
        public static double Mean(this List<byte> l)
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
        public static double Mean(this List<sbyte> l)
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
        public static double Mean(this List<short> l)
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
        public static double Mean(this List<ushort> l)
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
        public static double Mean(this List<int> l)
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
        public static double Mean(this List<uint> l)
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
        public static double Mean(this List<long> l)
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
        public static double Mean(this List<ulong> l)
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
        public static double Mean(this List<float> l)
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
        public static double Mean(this List<double> l)
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
        public static double Mean(this List<char> l)
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

        /// <summary>
        /// Finds the median of all the elements in the array.
        /// </summary>
        /// <param name="a">The array of type char</param>
        /// <returns>The median of all the elements in the array</returns>
        public static double Median(this int[] a)
        {
            if (a == null)
            {
                throw new NullReferenceException();
            }
            else switch (a.Length)
            {
                case 0:
                    throw new IndexOutOfRangeException("Array is empty.");
                case 1:
                    return a[0];
            }
            Array.Sort(a);
            if (a.Length % 2 == 0)
            {
                int l = a[(a.Length / 2) - 1];
                int h = a[a.Length / 2];
                double med = (l + h) / 2.0;
                return med;
            }
            return a[a.Length / 2];
        }
    }
}