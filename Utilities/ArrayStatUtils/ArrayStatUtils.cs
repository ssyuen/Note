using System;
using System.Collections;
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
    /// <summary>
    /// An Array Utility class for statistical methodology
    /// </summary>
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
        /// Finds the median of all the elements in the array.
        /// </summary>
        /// <param name="a">The array of type byte</param>
        /// <returns>The median of all the elements in the array</returns>
        public static double Median(this byte[] a)
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

        /// <summary>
        /// Finds the median of all the elements in the array.
        /// </summary>
        /// <param name="a">The array of type sbyte</param>
        /// <returns>The median of all the elements in the array</returns>
        public static double Median(this sbyte[] a)
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


        /// <summary>
        /// Finds the median of all the elements in the array.
        /// </summary>
        /// <param name="a">The array of type short</param>
        /// <returns>The median of all the elements in the array</returns>
        public static double Median(this short[] a)
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

        /// <summary>
        /// Finds the median of all the elements in the array.
        /// </summary>
        /// <param name="a">The array of type ushort</param>
        /// <returns>The median of all the elements in the array</returns>
        public static double Median(this ushort[] a)
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

        /// <summary>
        /// Finds the median of all the elements in the array.
        /// </summary>
        /// <param name="a">The array of type int</param>
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


        /// <summary>
        /// Finds the median of all the elements in the array.
        /// </summary>
        /// <param name="a">The array of type uint</param>
        /// <returns>The median of all the elements in the array</returns>
        public static double Median(this uint[] a)
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
                uint l = a[(a.Length / 2) - 1];
                uint h = a[a.Length / 2];
                double med = (l + h) / 2.0;
                return med;
            }
            return a[a.Length / 2];
        }

        /// <summary>
        /// Finds the median of all the elements in the array.
        /// </summary>
        /// <param name="a">The array of type long</param>
        /// <returns>The median of all the elements in the array</returns>
        public static double Median(this long[] a)
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
                long l = a[(a.Length / 2) - 1];
                long h = a[a.Length / 2];
                double med = (l + h) / 2.0;
                return med;
            }
            return a[a.Length / 2];
        }

        /// <summary>
        /// Finds the median of all the elements in the array.
        /// </summary>
        /// <param name="a">The array of type ulong</param>
        /// <returns>The median of all the elements in the array</returns>
        public static double Median(this ulong[] a)
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
                ulong l = a[(a.Length / 2) - 1];
                ulong h = a[a.Length / 2];
                double med = (l + h) / 2.0;
                return med;
            }
            return a[a.Length / 2];
        }

        /// <summary>
        /// Finds the median of all the elements in the array.
        /// </summary>
        /// <param name="a">The array of type float</param>
        /// <returns>The median of all the elements in the array</returns>
        public static double Median(this float[] a)
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
                float l = a[(a.Length / 2) - 1];
                float h = a[a.Length / 2];
                double med = (l + h) / 2.0;
                return med;
            }
            return a[a.Length / 2];
        }

        /// <summary>
        /// Finds the median of all the elements in the array.
        /// </summary>
        /// <param name="a">The array of type double</param>
        /// <returns>The median of all the elements in the array</returns>
        public static double Median(this double[] a)
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
                double l = a[(a.Length / 2) - 1];
                double h = a[a.Length / 2];
                double med = (l + h) / 2.0;
                return med;
            }
            return a[a.Length / 2];
        }

        /// <summary>
        /// Finds the median of all the elements in the array.
        /// </summary>
        /// <param name="a">The array of type char</param>
        /// <returns>The median of all the elements in the array</returns>
        public static double Median(this char[] a)
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
                char l = a[(a.Length / 2) - 1];
                char h = a[a.Length / 2];
                double med = (l + h) / 2.0;
                return med;
            }
            return a[a.Length / 2];
        }
        
        /// <summary>
        /// Finds the mode of all the elements in the array.
        /// </summary>
        /// <param name="a">The array of type byte</param>
        /// <returns>The median of all the elements in the array</returns>
        public static double Mode(this byte[]a)
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
            Dictionary<byte, int> hash = new Dictionary<byte, int>();
            foreach (var t in a)
            {
                if (hash.ContainsKey(t))hash[t] += 1;
                else hash.Add(t, 1);
            }

            var keysInDict = hash.Keys.ToArray();
            var numOfMode = hash.Values.ToArray();
            
            var max = numOfMode[0];
            var index = 0;
            var allEqual = 0;
            for (var i = 0; i < hash.Count; i++)
            {
                if (max < numOfMode[i])
                {
                    max = numOfMode[i];
                    index = i;
                }
                if (max == numOfMode[i]) allEqual++;
            }

            if (allEqual != numOfMode.Length) return keysInDict[index];
            
            Console.WriteLine("No Mode Present");
            return 0;
        }
        /// <summary>
        /// Finds the mode of all the elements in the array.
        /// </summary>
        /// <param name="a">The array of type byte</param>
        /// <returns>The median of all the elements in the array</returns>
        public static double Mode(this sbyte[]a)
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
            Dictionary<sbyte, int> hash = new Dictionary<sbyte, int>();
            foreach (var t in a)
            {
                if (hash.ContainsKey(t))hash[t] += 1;
                else hash.Add(t, 1);
            }

            var keysInDict = hash.Keys.ToArray();
            var numOfMode = hash.Values.ToArray();
            
            var max = numOfMode[0];
            var index = 0;
            var allEqual = 0;
            for (var i = 0; i < hash.Count; i++)
            {
                if (max < numOfMode[i])
                {
                    max = numOfMode[i];
                    index = i;
                }
                if (max == numOfMode[i]) allEqual++;
            }

            if (allEqual != numOfMode.Length) return keysInDict[index];
            
            Console.WriteLine("No Mode Present");
            return 0;
        }
        /// <summary>
        /// Finds the mode of all the elements in the array.
        /// </summary>
        /// <param name="a">The array of type byte</param>
        /// <returns>The median of all the elements in the array</returns>
        public static double Mode(this short[]a)
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
            Dictionary<short, int> hash = new Dictionary<short, int>();
            foreach (var t in a)
            {
                if (hash.ContainsKey(t))hash[t] += 1;
                else hash.Add(t, 1);
            }

            var keysInDict = hash.Keys.ToArray();
            var numOfMode = hash.Values.ToArray();
            
            var max = numOfMode[0];
            var index = 0;
            var allEqual = 0;
            for (var i = 0; i < hash.Count; i++)
            {
                if (max < numOfMode[i])
                {
                    max = numOfMode[i];
                    index = i;
                }
                if (max == numOfMode[i]) allEqual++;
            }

            if (allEqual != numOfMode.Length) return keysInDict[index];
            
            Console.WriteLine("No Mode Present");
            return 0;
        }
        /// <summary>
        /// Finds the mode of all the elements in the array.
        /// </summary>
        /// <param name="a">The array of type byte</param>
        /// <returns>The median of all the elements in the array</returns>
        public static double Mode(this ushort[]a)
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
            Dictionary<ushort, int> hash = new Dictionary<ushort, int>();
            foreach (var t in a)
            {
                if (hash.ContainsKey(t))hash[t] += 1;
                else hash.Add(t, 1);
            }

            var keysInDict = hash.Keys.ToArray();
            var numOfMode = hash.Values.ToArray();
            
            var max = numOfMode[0];
            var index = 0;
            var allEqual = 0;
            for (var i = 0; i < hash.Count; i++)
            {
                if (max < numOfMode[i])
                {
                    max = numOfMode[i];
                    index = i;
                }
                if (max == numOfMode[i]) allEqual++;
            }

            if (allEqual != numOfMode.Length) return keysInDict[index];
            
            Console.WriteLine("No Mode Present");
            return 0;
        }
        /// <summary>
        /// Finds the mode of all the elements in the array.
        /// </summary>
        /// <param name="a">The array of type byte</param>
        /// <returns>The median of all the elements in the array</returns>
        public static double Mode(this int[]a)
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
            Dictionary<int, int> hash = new Dictionary<int, int>();
            foreach (var t in a)
            {
                if (hash.ContainsKey(t))hash[t] += 1;
                else hash.Add(t, 1);
            }

            var keysInDict = hash.Keys.ToArray();
            var numOfMode = hash.Values.ToArray();
            
            var max = numOfMode[0];
            var index = 0;
            var allEqual = 0;
            for (var i = 0; i < hash.Count; i++)
            {
                if (max < numOfMode[i])
                {
                    max = numOfMode[i];
                    index = i;
                }
                if (max == numOfMode[i]) allEqual++;
            }

            if (allEqual != numOfMode.Length) return keysInDict[index];
            
            Console.WriteLine("No Mode Present");
            return 0;
        }
        /// <summary>
        /// Finds the mode of all the elements in the array.
        /// </summary>
        /// <param name="a">The array of type byte</param>
        /// <returns>The median of all the elements in the array</returns>
        public static double Mode(this uint[]a)
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
            Dictionary<uint, int> hash = new Dictionary<uint, int>();
            foreach (var t in a)
            {
                if (hash.ContainsKey(t))hash[t] += 1;
                else hash.Add(t, 1);
            }

            var keysInDict = hash.Keys.ToArray();
            var numOfMode = hash.Values.ToArray();
            
            var max = numOfMode[0];
            var index = 0;
            var allEqual = 0;
            for (var i = 0; i < hash.Count; i++)
            {
                if (max < numOfMode[i])
                {
                    max = numOfMode[i];
                    index = i;
                }
                if (max == numOfMode[i]) allEqual++;
            }

            if (allEqual != numOfMode.Length) return keysInDict[index];
            
            Console.WriteLine("No Mode Present");
            return 0;
        }
        /// <summary>
        /// Finds the mode of all the elements in the array.
        /// </summary>
        /// <param name="a">The array of type byte</param>
        /// <returns>The median of all the elements in the array</returns>
        public static double Mode(this long[]a)
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
            Dictionary<long, int> hash = new Dictionary<long, int>();
            foreach (var t in a)
            {
                if (hash.ContainsKey(t))hash[t] += 1;
                else hash.Add(t, 1);
            }

            var keysInDict = hash.Keys.ToArray();
            var numOfMode = hash.Values.ToArray();
            
            var max = numOfMode[0];
            var index = 0;
            var allEqual = 0;
            for (var i = 0; i < hash.Count; i++)
            {
                if (max < numOfMode[i])
                {
                    max = numOfMode[i];
                    index = i;
                }
                if (max == numOfMode[i]) allEqual++;
            }

            if (allEqual != numOfMode.Length) return keysInDict[index];
            
            Console.WriteLine("No Mode Present");
            return 0;
        }
        /// <summary>
        /// Finds the mode of all the elements in the array.
        /// </summary>
        /// <param name="a">The array of type byte</param>
        /// <returns>The median of all the elements in the array</returns>
        public static double Mode(this ulong[]a)
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
            Dictionary<ulong, int> hash = new Dictionary<ulong, int>();
            foreach (var t in a)
            {
                if (hash.ContainsKey(t))hash[t] += 1;
                else hash.Add(t, 1);
            }

            var keysInDict = hash.Keys.ToArray();
            var numOfMode = hash.Values.ToArray();
            
            var max = numOfMode[0];
            var index = 0;
            var allEqual = 0;
            for (var i = 0; i < hash.Count; i++)
            {
                if (max < numOfMode[i])
                {
                    max = numOfMode[i];
                    index = i;
                }
                if (max == numOfMode[i]) allEqual++;
            }

            if (allEqual != numOfMode.Length) return keysInDict[index];
            
            Console.WriteLine("No Mode Present");
            return 0;
        }
        /// <summary>
        /// Finds the mode of all the elements in the array.
        /// </summary>
        /// <param name="a">The array of type byte</param>
        /// <returns>The median of all the elements in the array</returns>
        public static double Mode(this float[]a)
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
            Dictionary<float, int> hash = new Dictionary<float, int>();
            foreach (var t in a)
            {
                if (hash.ContainsKey(t))hash[t] += 1;
                else hash.Add(t, 1);
            }

            var keysInDict = hash.Keys.ToArray();
            var numOfMode = hash.Values.ToArray();
            
            var max = numOfMode[0];
            var index = 0;
            var allEqual = 0;
            for (var i = 0; i < hash.Count; i++)
            {
                if (max < numOfMode[i])
                {
                    max = numOfMode[i];
                    index = i;
                }
                if (max == numOfMode[i]) allEqual++;
            }

            if (allEqual != numOfMode.Length) return keysInDict[index];
            
            Console.WriteLine("No Mode Present");
            return 0;
        }
        /// <summary>
        /// Finds the mode of all the elements in the array.
        /// </summary>
        /// <param name="a">The array of type byte</param>
        /// <returns>The median of all the elements in the array</returns>
        public static double Mode(this double[]a)
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
            Dictionary<double, int> hash = new Dictionary<double, int>();
            foreach (var t in a)
            {
                if (hash.ContainsKey(t))hash[t] += 1;
                else hash.Add(t, 1);
            }

            var keysInDict = hash.Keys.ToArray();
            var numOfMode = hash.Values.ToArray();
            
            var max = numOfMode[0];
            var index = 0;
            var allEqual = 0;
            for (var i = 0; i < hash.Count; i++)
            {
                if (max < numOfMode[i])
                {
                    max = numOfMode[i];
                    index = i;
                }
                if (max == numOfMode[i]) allEqual++;
            }

            //if # of mode not all equal
            if (allEqual != numOfMode.Length) return keysInDict[index];
            
            Console.WriteLine("No Mode Present");
            return 0;
        }
        /// <summary>
        /// Finds the mode of all the elements in the array.
        /// </summary>
        /// <param name="a">The array of type byte</param>
        /// <returns>The median of all the elements in the array</returns>
        public static double Mode(this char[]a)
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
            Dictionary<char, int> hash = new Dictionary<char, int>();
            foreach (var t in a)
            {
                if (hash.ContainsKey(t))hash[t] += 1;
                else hash.Add(t, 1);
            }

            var keysInDict = hash.Keys.ToArray();
            var numOfMode = hash.Values.ToArray();
            
            var max = numOfMode[0];
            var index = 0;
            var allEqual = 0;
            for (var i = 0; i < hash.Count; i++)
            {
                if (max < numOfMode[i])
                {
                    max = numOfMode[i];
                    index = i;
                }
                if (max == numOfMode[i]) allEqual++;
            }

            if (allEqual != numOfMode.Length) return keysInDict[index];
            
            Console.WriteLine("No Mode Present");
            return 0;
        }

        /// <summary>
        /// Finds the sample standard deviation of the array.
        /// </summary>
        /// <param name="a">The array of type int</param>
        /// <returns>The median of all the elements in the array</returns>
        public static double SampleStdDev(this int[] a)
        {
            var variance = SampleVariance(a);
            return Math.Round(variance, 2);
        }
        
        /// <summary>
        /// Finds the population standard deviation of the array.
        /// </summary>
        /// <param name="a">The array of type int</param>
        /// <returns>The median of all the elements in the array</returns>
        public static double PopStdDev(this int[] a)
        {
            var variance = PopVariance(a);
            return Math.Round(variance, 2);
        }

        /// <summary>
        /// Finds the standard error of the array.
        /// </summary>
        /// <param name="a">The array of type int</param>
        /// <returns>The standard error of all the elements in the array</returns>
        public static double StdErr(this int[] a)
        {
            var stdDev = SampleStdDev(a);
            return stdDev/(Math.Sqrt(a.Length));
        }

        /// <summary>
        /// Finds the sample variance of the array.
        /// </summary>
        /// <param name="a">The array of type int</param>
        /// <returns>The sample variance of all the elements in the array</returns>
        public static double SampleVariance(this int[] a)
        {
            double mean = Mean(a);
            double sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                sum += Math.Pow((a[i] - mean), 2);
            }
            sum /= (a.Length - 1); //n-1 denoted as bessel's correction for sample standard dev
            
            return sum;
        }
        
        /// <summary>
        /// Finds the population variance of the array.
        /// </summary>
        /// <param name="a">The array of type int</param>
        /// <returns>The population variance of all the elements in the array</returns>
        public static double PopVariance(this int[] a)
        {
            double mean = Mean(a);
            double sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                sum += Math.Pow((a[i] - mean), 2);
            }
            sum /= (a.Length); 
            
            return sum;
        }

        /// <summary>
        /// Finds the minimum of the array.
        /// </summary>
        /// <param name="a">The array of type int</param>
        /// <returns>The minimum of all the elements in the array</returns>
        public static double Minimum(this int[] a)
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
            var min = a[0];
            for (int i = 0; i < a.Length; i++)
            {
                if (min > a[i])
                {
                    min = a[i];
                }
            }
            return min;
        }

        /// <summary>
        /// Finds the maximum of the array.
        /// </summary>
        /// <param name="a">The array of type int</param>
        /// <returns>The maximum of all the elements in the array</returns>
        public static double Maximum(this int[] a)
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
            var max = a[0];
            for (int i = 0; i < a.Length; i++)
            {
                if (max > a[i])
                {
                    max = a[i];
                }
            }
            return max;
        }

        /// <summary>
        /// Finds the range of the array.
        /// </summary>
        /// <param name="a">The array of type int</param>
        /// <returns>The range of all the elements in the array</returns>
        public static double Range(this int[] a)
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

            var range = a[a.Length - 1] - a[0];
            return range;
        }

        /// <summary>
        /// Finds the lower quartile of the array.
        /// </summary>
        /// <param name="a">The array of type int</param>
        /// <returns>The lower quartile of all the elements in the array</returns>
        public static double LowerQuart(this int[] a)
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
                    Console.WriteLine("Data set not large enough to calculate an lower quartile.");
                    break;
                case 2:
                    Console.WriteLine("Data set not large enough to calculate an lower quartile.");
                    break;
            }
            var lowerHalf = new int[a.Length / 2];
            
            return Median(lowerHalf);
        }
        
        /// <summary>
        /// Finds the upper quartile of the array.
        /// </summary>
        /// <param name="a">The array of type int</param>
        /// <returns>The upper quartile of all the elements in the array</returns>
        public static double UpperQuart(this int[] a)
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
                    Console.WriteLine("Data set not large enough to calculate an upper quartile.");
                    break;
                case 2:
                    Console.WriteLine("Data set not large enough to calculate an upper quartile.");
                    break;
            }
            var upperHalf = new int[a.Length / 2];
            
            return Median(upperHalf);
        }
        
        /// <summary>
        /// Finds the inter-quartile range of the array.
        /// </summary>
        /// <param name="a">The array of type int</param>
        /// <returns>The inter-quartile range of all the elements in the array</returns>
        public static double InterQuartileRange(this int[] a)
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
                    Console.WriteLine("Data set not large enough to calculate an inter-quartile range.");
                    break;
                case 2:
                    Console.WriteLine("Data set not large enough to calculate an inter-quartile range.");
                    break;
            }

            var lowerQuart = LowerQuart(a);
            var upperQuart = UpperQuart(a);
            return upperQuart - lowerQuart;
        }
        
    }//ArrayStatUtils
}//namespace Utilities
