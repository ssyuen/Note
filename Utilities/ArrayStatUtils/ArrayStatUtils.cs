using System;
using System.Collections.Generic;
using System.Linq;
using Utilities.UtilExceptions;

namespace Utilities
{
    /// <summary>
    /// An Array Utility class for statistical methodology
    /// </summary>
    public static class ArrayStatUtils
    {

        /*
         * The tolerance level (upper and lower limits)
         */ 
        private const double TOLERANCE = 0.00000000000000000000000;

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

            throw new NoModeException("No Mode Present");
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

            throw new NoModeException("No Mode Present");

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

            throw new NoModeException("No Mode Present");
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

            throw new NoModeException("No Mode Present");
            
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

            throw new NoModeException("No Mode Present");

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

            throw new NoModeException("No Mode Present");
        }

        /// <summary>
        /// Finds the sample standard deviation of the array.
        /// </summary>
        /// <param name="a">The array of type byte</param>
        /// <returns>The median of all the elements in the array</returns>
        public static double SampleStdDev(this byte[] a)
        {
            var variance = SampleVariance(a);
            return Math.Round(variance, 2);
        }

        /// <summary>
        /// Finds the sample standard deviation of the array.
        /// </summary>
        /// <param name="a">The array of type short</param>
        /// <returns>The median of all the elements in the array</returns>
        public static double SampleStdDev(this short[] a)
        {
            var variance = SampleVariance(a);
            return Math.Round(variance, 2);
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
        /// Finds the sample standard deviation of the array.
        /// </summary>
        /// <param name="a">The array of type long</param>
        /// <returns>The median of all the elements in the array</returns>
        public static double SampleStdDev(this long[] a)
        {
            var variance = SampleVariance(a);
            return Math.Round(variance, 2);
        }

        /// <summary>
        /// Finds the sample standard deviation of the array.
        /// </summary>
        /// <param name="a">The array of type float</param>
        /// <returns>The median of all the elements in the array</returns>
        public static double SampleStdDev(this float[] a)
        {
            var variance = SampleVariance(a);
            return Math.Round(variance, 2);
        }

        /// <summary>
        /// Finds the sample standard deviation of the array.
        /// </summary>
        /// <param name="a">The array of type double</param>
        /// <returns>The median of all the elements in the array</returns>
        public static double SampleStdDev(this double[] a)
        {
            var variance = SampleVariance(a);
            return Math.Round(variance, 2);
        }

        /// <summary>
        /// Finds the population standard deviation of the array.
        /// </summary>
        /// <param name="a">The array of type byte</param>
        /// <returns>The median of all the elements in the array</returns>
        public static double PopStdDev(this byte[] a)
        {
            var variance = PopVariance(a);
            return Math.Round(variance, 2);
        }

        /// <summary>
        /// Finds the population standard deviation of the array.
        /// </summary>
        /// <param name="a">The array of type short</param>
        /// <returns>The median of all the elements in the array</returns>
        public static double PopStdDev(this short[] a)
        {
            var variance = PopVariance(a);
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
        /// Finds the population standard deviation of the array.
        /// </summary>
        /// <param name="a">The array of type long</param>
        /// <returns>The median of all the elements in the array</returns>
        public static double PopStdDev(this long[] a)
        {
            var variance = PopVariance(a);
            return Math.Round(variance, 2);
        }

        /// <summary>
        /// Finds the population standard deviation of the array.
        /// </summary>
        /// <param name="a">The array of type float</param>
        /// <returns>The median of all the elements in the array</returns>
        public static double PopStdDev(this float[] a)
        {
            var variance = PopVariance(a);
            return Math.Round(variance, 2);
        }

        /// <summary>
        /// Finds the population standard deviation of the array.
        /// </summary>
        /// <param name="a">The array of type sbyte</param>
        /// <returns>The median of all the elements in the array</returns>
        public static double PopStdDev(this double[] a)
        {
            var variance = PopVariance(a);
            return Math.Round(variance, 2);
        }

        /// <summary>
        /// Finds the standard error of the array.
        /// </summary>
        /// <param name="a">The array of type byte</param>
        /// <returns>The standard error of all the elements in the array</returns>
        public static double StdErr(this byte[] a)
        {
            var stdDev = SampleStdDev(a);
            return stdDev/(Math.Sqrt(a.Length));
        }

        /// <summary>
        /// Finds the standard error of the array.
        /// </summary>
        /// <param name="a">The array of type short</param>
        /// <returns>The standard error of all the elements in the array</returns>
        public static double StdErr(this short[] a)
        {
            var stdDev = SampleStdDev(a);
            return stdDev/(Math.Sqrt(a.Length));
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
        /// Finds the standard error of the array.
        /// </summary>
        /// <param name="a">The array of type float</param>
        /// <returns>The standard error of all the elements in the array</returns>
        public static double StdErr(this float[] a)
        {
            var stdDev = SampleStdDev(a);
            return stdDev/(Math.Sqrt(a.Length));
        }

        /// <summary>
        /// Finds the standard error of the array.
        /// </summary>
        /// <param name="a">The array of type double</param>
        /// <returns>The standard error of all the elements in the array</returns>
        public static double StdErr(this double[] a)
        {
            var stdDev = SampleStdDev(a);
            return stdDev/(Math.Sqrt(a.Length));
        }

        /// <summary>
        /// Finds the sample variance of the array.
        /// </summary>
        /// <param name="a">The array of type byte</param>
        /// <returns>The sample variance of all the elements in the array</returns>
        public static double SampleVariance(this byte[] a)
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
        /// Finds the sample variance of the array.
        /// </summary>
        /// <param name="a">The array of type short</param>
        /// <returns>The sample variance of all the elements in the array</returns>
        public static double SampleVariance(this short[] a)
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
        /// Finds the sample variance of the array.
        /// </summary>
        /// <param name="a">The array of type long</param>
        /// <returns>The sample variance of all the elements in the array</returns>
        public static double SampleVariance(this long[] a)
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
        /// Finds the sample variance of the array.
        /// </summary>
        /// <param name="a">The array of type float</param>
        /// <returns>The sample variance of all the elements in the array</returns>
        public static double SampleVariance(this float[] a)
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
        /// Finds the sample variance of the array.
        /// </summary>
        /// <param name="a">The array of type double</param>
        /// <returns>The sample variance of all the elements in the array</returns>
        public static double SampleVariance(this double[] a)
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
        /// <param name="a">The array of type byte</param>
        /// <returns>The population variance of all the elements in the array</returns>
        public static double PopVariance(this byte[] a)
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
        /// Finds the population variance of the array.
        /// </summary>
        /// <param name="a">The array of type short</param>
        /// <returns>The population variance of all the elements in the array</returns>
        public static double PopVariance(this short[] a)
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
        /// Finds the population variance of the array.
        /// </summary>
        /// <param name="a">The array of type long</param>
        /// <returns>The population variance of all the elements in the array</returns>
        public static double PopVariance(this long[] a)
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
        /// Finds the population variance of the array.
        /// </summary>
        /// <param name="a">The array of type float</param>
        /// <returns>The population variance of all the elements in the array</returns>
        public static double PopVariance(this float[] a)
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
        /// Finds the population variance of the array.
        /// </summary>
        /// <param name="a">The array of type double</param>
        /// <returns>The population variance of all the elements in the array</returns>
        public static double PopVariance(this double[] a)
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
        /// Finds the smallest element in the array.
        /// </summary>
        /// <param name="a">The array of type byte</param>
        /// <returns>The minimum of all the elements in the array</returns>
        public static double Minimum(this byte[] a)
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
            byte min;
            if(a[0] > a[1])
            {
                min = a[1];
            }
            else
            {
                min = a[0];
            }
            for(int i = 2; i < a.Length; i++){
                if(a[i] < min)
                {
                    min = a[i];
                }
            }
            return min;
        }

        /// <summary>
        /// Finds the smallest element in the array.
        /// </summary>
        /// <param name="a">The array of type byte</param>
        /// <returns>The minimum of all the elements in the array</returns>
        public static double Minimum(this short[] a)
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
            short min;
            if(a[0] > a[1])
            {
                min = a[1];
            }
            else
            {
                min = a[0];
            }
            for(int i = 2; i < a.Length; i++){
                if(a[i] < min)
                {
                    min = a[i];
                }
            }
            return min;
        }

        /// <summary>
        /// Finds the smallest element of the array.
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
            int min;
            if(a[0] > a[1])
            {
                min = a[1];
            }
            else
            {
                min = a[0];
            }
            for(int i = 2; i < a.Length; i++){
                if(a[i] < min)
                {
                    min = a[i];
                }
            }
            return min;
        }

        /// <summary>
        /// Finds the smallest element of the array.
        /// </summary>
        /// <param name="a">The array of type long</param>
        /// <returns>The minimum of all the elements in the array</returns>
        public static double Minimum(this long[] a)
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
            long min;
            if(a[0] > a[1])
            {
                min = a[1];
            }
            else
            {
                min = a[0];
            }
            for(int i = 2; i < a.Length; i++){
                if(a[i] < min)
                {
                    min = a[i];
                }
            }
            return min;
        }

        /// <summary>
        /// Finds the smallest element of the array.
        /// </summary>
        /// <param name="a">The array of type float</param>
        /// <returns>The minimum of all the elements in the array</returns>
        public static double Minimum(this float[] a)
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
            float min;
            if(a[0] > a[1])
            {
                min = a[1];
            }
            else
            {
                min = a[0];
            }
            for(int i = 2; i < a.Length; i++){
                if(a[i] < min)
                {
                    min = a[i];
                }
            }
            return min;
        }

        /// <summary>
        /// Finds the smallest element of the array.
        /// </summary>
        /// <param name="a">The array of type double</param>
        /// <returns>The minimum of all the elements in the array</returns>
        public static double Minimum(this double[] a)
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
            double min;
            if(a[0] > a[1])
            {
                min = a[1];
            }
            else
            {
                min = a[0];
            }
            for(int i = 2; i < a.Length; i++){
                if(a[i] < min)
                {
                    min = a[i];
                }
            }
            return min;
        }

        /// <summary>
        /// Finds the largest element in the array.
        /// </summary>
        /// <param name="a">The array of type byte</param>
        /// <returns>The maximum of all the elements in the array</returns>
        public static double Maximum(this byte[] a)
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
            byte max;
            if(a[0] > a[1])
            {
                max = a[0];
            }
            else
            {
                max = a[1];
            }
            for(int i = 2; i < a.Length; i++){
                if(a[i] > max)
                {
                    max = a[i];
                }
            }
            return max;
        }

        /// <summary>
        /// Finds the largest element in the array.
        /// </summary>
        /// <param name="a">The array of type short</param>
        /// <returns>The maximum of all the elements in the array</returns>
        public static double Maximum(this short[] a)
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
            short max;
            if(a[0] > a[1])
            {
                max = a[0];
            }
            else
            {
                max = a[1];
            }
            for(int i = 2; i < a.Length; i++){
                if(a[i] > max)
                {
                    max = a[i];
                }
            }
            return max;
        }

        /// <summary>
        /// Finds the largest element in the array.
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
            int max;
            if(a[0] > a[1])
            {
                max = a[0];
            }
            else
            {
                max = a[1];
            }
            for(int i = 2; i < a.Length; i++){
                if(a[i] > max)
                {
                    max = a[i];
                }
            }
            return max;
        }

        /// <summary>
        /// Finds the largest element in the array.
        /// </summary>
        /// <param name="a">The array of type long</param>
        /// <returns>The maximum of all the elements in the array</returns>
        public static double Maximum(this long[] a)
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
            long max;
            if(a[0] > a[1])
            {
                max = a[0];
            }
            else
            {
                max = a[1];
            }
            for(int i = 2; i < a.Length; i++){
                if(a[i] > max)
                {
                    max = a[i];
                }
            }
            return max;
        }

        /// <summary>
        /// Finds the largest element in the array.
        /// </summary>
        /// <param name="a">The array of type float</param>
        /// <returns>The maximum of all the elements in the array</returns>
        public static double Maximum(this float[] a)
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
            float max;
            if(a[0] > a[1])
            {
                max = a[0];
            }
            else
            {
                max = a[1];
            }
            for(int i = 2; i < a.Length; i++){
                if(a[i] > max)
                {
                    max = a[i];
                }
            }
            return max;
        }

        /// <summary>
        /// Finds the largest element in the array.
        /// </summary>
        /// <param name="a">The array of type double</param>
        /// <returns>The maximum of all the elements in the array</returns>
        public static double Maximum(this double[] a)
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
            double max;
            if(a[0] > a[1])
            {
                max = a[0];
            }
            else
            {
                max = a[1];
            }
            for(int i = 2; i < a.Length; i++){
                if(a[i] > max)
                {
                    max = a[i];
                }
            }
            return max;
        }

        /// <summary>
        /// Finds the range of the array.
        /// </summary>
        /// <param name="a">The array of type byte</param>
        /// <returns>The range of all the elements in the array</returns>
        public static double Range(this byte[] a)
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
        /// Finds the range of the array.
        /// </summary>
        /// <param name="a">The array of type short</param>
        /// <returns>The range of all the elements in the array</returns>
        public static double Range(this short[] a)
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
        /// Finds the range of the array.
        /// </summary>
        /// <param name="a">The array of type long</param>
        /// <returns>The range of all the elements in the array</returns>
        public static double Range(this long[] a)
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
        /// Finds the range of the array.
        /// </summary>
        /// <param name="a">The array of type float</param>
        /// <returns>The range of all the elements in the array</returns>
        public static double Range(this float[] a)
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
        /// Finds the range of the array.
        /// </summary>
        /// <param name="a">The array of type double</param>
        /// <returns>The range of all the elements in the array</returns>
        public static double Range(this double[] a)
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
        /// <param name="a">The array of type byte</param>
        /// <returns>The lower quartile of all the elements in the array</returns>
        public static double LowerQuartile(this byte[] a)
        {
            if (a == null)
            {
                throw new NullReferenceException();
            }
            else switch (a.Length)
            {
                case 0:
                    throw new IndexOutOfRangeException("Array is empty.");
                case 1: case 2:
                    throw new InsufficientDataSetException("Data set not large enough to calculate an lower quartile");        
            }
            var lowerHalf = new int[a.Length / 2];
            return Median(lowerHalf);
        }

        /// <summary>
        /// Finds the lower quartile of the array.
        /// </summary>
        /// <param name="a">The array of type short</param>
        /// <returns>The lower quartile of all the elements in the array</returns>
        public static double LowerQuartile(this short[] a)
        {
            if (a == null)
            {
                throw new NullReferenceException();
            }
            else switch (a.Length)
            {
                case 0:
                    throw new IndexOutOfRangeException("Array is empty.");
                case 1: case 2:
                    throw new InsufficientDataSetException("Data set not large enough to calculate an lower quartile");        
            }
            var lowerHalf = new int[a.Length / 2];
            return Median(lowerHalf);
        }


        /// <summary>
        /// Finds the lower quartile of the array.
        /// </summary>
        /// <param name="a">The array of type int</param>
        /// <returns>The lower quartile of all the elements in the array</returns>
        public static double LowerQuartile(this int[] a)
        {
            if (a == null)
            {
                throw new NullReferenceException();
            }
            else switch (a.Length)
            {
                case 0:
                    throw new IndexOutOfRangeException("Array is empty.");
                case 1: case 2:
                    throw new InsufficientDataSetException("Data set not large enough to calculate an lower quartile");        
            }
            var lowerHalf = new int[a.Length / 2];
            return Median(lowerHalf);
        }


        /// <summary>
        /// Finds the lower quartile of the array.
        /// </summary>
        /// <param name="a">The array of type long</param>
        /// <returns>The lower quartile of all the elements in the array</returns>
        public static double LowerQuartile(this long[] a)
        {
            if (a == null)
            {
                throw new NullReferenceException();
            }
            else switch (a.Length)
            {
                case 0:
                    throw new IndexOutOfRangeException("Array is empty.");
                case 1: case 2:
                    throw new InsufficientDataSetException("Data set not large enough to calculate an lower quartile");        
            }
            var lowerHalf = new int[a.Length / 2];
            return Median(lowerHalf);
        }


        /// <summary>
        /// Finds the lower quartile of the array.
        /// </summary>
        /// <param name="a">The array of type float</param>
        /// <returns>The lower quartile of all the elements in the array</returns>
        public static double LowerQuartile(this float[] a)
        {
            if (a == null)
            {
                throw new NullReferenceException();
            }
            else switch (a.Length)
            {
                case 0:
                    throw new IndexOutOfRangeException("Array is empty.");
                case 1: case 2:
                    throw new InsufficientDataSetException("Data set not large enough to calculate an lower quartile");        
            }
            var lowerHalf = new int[a.Length / 2];
            return Median(lowerHalf);
        }

        /// <summary>
        /// Finds the lower quartile of the array.
        /// </summary>
        /// <param name="a">The array of type double</param>
        /// <returns>The lower quartile of all the elements in the array</returns>
        public static double LowerQuartile(this double[] a)
        {
            if (a == null)
            {
                throw new NullReferenceException();
            }
            else switch (a.Length)
            {
                case 0:
                    throw new IndexOutOfRangeException("Array is empty.");
                case 1: case 2:
                    throw new InsufficientDataSetException("Data set not large enough to calculate an lower quartile");        
            }
            var lowerHalf = new int[a.Length / 2];
            return Median(lowerHalf);
        }

        /// <summary>
        /// Finds the upper quartile of the array.
        /// </summary>
        /// <param name="a">The array of type byte</param>
        /// <returns>The upper quartile of all the elements in the array</returns>
        public static double UpperQuartile(this byte[] a)
        {
            if (a == null)
            {
                throw new NullReferenceException();
            }
            else switch (a.Length)
            {
                case 0:
                    throw new IndexOutOfRangeException("Array is empty.");
                case 1: case 2:
                    throw new InsufficientDataSetException("Data set not large enough to calculate an upper quartile");
            }
            var upperHalf = new int[a.Length / 2];

            return Median(upperHalf);
        }

        /// <summary>
        /// Finds the upper quartile of the array.
        /// </summary>
        /// <param name="a">The array of type short</param>
        /// <returns>The upper quartile of all the elements in the array</returns>
        public static double UpperQuartile(this short[] a)
        {
            if (a == null)
            {
                throw new NullReferenceException();
            }
            else switch (a.Length)
            {
                case 0:
                    throw new IndexOutOfRangeException("Array is empty.");
                case 1: case 2:
                    throw new InsufficientDataSetException("Data set not large enough to calculate an upper quartile");
            }
            var upperHalf = new int[a.Length / 2];

            return Median(upperHalf);
        }

        /// <summary>
        /// Finds the upper quartile of the array.
        /// </summary>
        /// <param name="a">The array of type int</param>
        /// <returns>The upper quartile of all the elements in the array</returns>
        public static double UpperQuartile(this int[] a)
        {
            if (a == null)
            {
                throw new NullReferenceException();
            }
            else switch (a.Length)
            {
                case 0:
                    throw new IndexOutOfRangeException("Array is empty.");
                case 1: case 2:
                    throw new InsufficientDataSetException("Data set not large enough to calculate an upper quartile");
            }
            var upperHalf = new int[a.Length / 2];

            return Median(upperHalf);
        }

        /// <summary>
        /// Finds the upper quartile of the array.
        /// </summary>
        /// <param name="a">The array of type long</param>
        /// <returns>The upper quartile of all the elements in the array</returns>
        public static double UpperQuartile(this long[] a)
        {
            if (a == null)
            {
                throw new NullReferenceException();
            }
            else switch (a.Length)
            {
                case 0:
                    throw new IndexOutOfRangeException("Array is empty.");
                case 1: case 2:
                    throw new InsufficientDataSetException("Data set not large enough to calculate an upper quartile");
            }
            var upperHalf = new int[a.Length / 2];

            return Median(upperHalf);
        }

        /// <summary>
        /// Finds the upper quartile of the array.
        /// </summary>
        /// <param name="a">The array of type float</param>
        /// <returns>The upper quartile of all the elements in the array</returns>
        public static double UpperQuartile(this float[] a)
        {
            if (a == null)
            {
                throw new NullReferenceException();
            }
            else switch (a.Length)
            {
                case 0:
                    throw new IndexOutOfRangeException("Array is empty.");
                case 1: case 2:
                    throw new InsufficientDataSetException("Data set not large enough to calculate an upper quartile");
            }
            var upperHalf = new int[a.Length / 2];

            return Median(upperHalf);
        }

        /// <summary>
        /// Finds the upper quartile of the array.
        /// </summary>
        /// <param name="a">The array of type double</param>
        /// <returns>The upper quartile of all the elements in the array</returns>
        public static double UpperQuartile(this double[] a)
        {
            if (a == null)
            {
                throw new NullReferenceException();
            }
            else switch (a.Length)
            {
                case 0:
                    throw new IndexOutOfRangeException("Array is empty.");
                case 1: case 2:
                    throw new InsufficientDataSetException("Data set not large enough to calculate an upper quartile");
            }
            var upperHalf = new int[a.Length / 2];

            return Median(upperHalf);
        }

        /// <summary>
        /// Finds the inter-quartile range of the array.
        /// </summary>
        /// <param name="a">The array of type byte</param>
        /// <returns>The inter-quartile range of all the elements in the array</returns>
        public static double InterQuartileRange(this byte[] a)
        {
            if (a == null)
            {
                throw new NullReferenceException();
            }
            else switch (a.Length)
            {
                case 0:
                    throw new IndexOutOfRangeException("Array is empty.");
                case 1: case 2:
                    throw new InsufficientDataSetException("Data set not large enough to calculate an inter-quartile range");
            }

            var lowerQuart = LowerQuartile(a);
            var upperQuart = UpperQuartile(a);
            return upperQuart - lowerQuart;
        }

        /// <summary>
        /// Finds the inter-quartile range of the array.
        /// </summary>
        /// <param name="a">The array of type short</param>
        /// <returns>The inter-quartile range of all the elements in the array</returns>
        public static double InterQuartileRange(this short[] a)
        {
            if (a == null)
            {
                throw new NullReferenceException();
            }
            else switch (a.Length)
            {
                case 0:
                    throw new IndexOutOfRangeException("Array is empty.");
                case 1: case 2:
                    throw new InsufficientDataSetException("Data set not large enough to calculate an inter-quartile range");
            }

            var lowerQuart = LowerQuartile(a);
            var upperQuart = UpperQuartile(a);
            return upperQuart - lowerQuart;
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
                case 1: case 2:
                    throw new InsufficientDataSetException("Data set not large enough to calculate an inter-quartile range");
            }

            var lowerQuart = LowerQuartile(a);
            var upperQuart = UpperQuartile(a);
            return upperQuart - lowerQuart;
        }

        /// <summary>
        /// Finds the inter-quartile range of the array.
        /// </summary>
        /// <param name="a">The array of type long</param>
        /// <returns>The inter-quartile range of all the elements in the array</returns>
        public static double InterQuartileRange(this long[] a)
        {
            if (a == null)
            {
                throw new NullReferenceException();
            }
            else switch (a.Length)
            {
                case 0:
                    throw new IndexOutOfRangeException("Array is empty.");
                case 1: case 2:
                    throw new InsufficientDataSetException("Data set not large enough to calculate an inter-quartile range");
            }

            var lowerQuart = LowerQuartile(a);
            var upperQuart = UpperQuartile(a);
            return upperQuart - lowerQuart;
        }

       /// <summary>
        /// Finds the inter-quartile range of the array.
        /// </summary>
        /// <param name="a">The array of type float</param>
        /// <returns>The inter-quartile range of all the elements in the array</returns>
        public static double InterQuartileRange(this float[] a)
        {
            if (a == null)
            {
                throw new NullReferenceException();
            }
            else switch (a.Length)
            {
                case 0:
                    throw new IndexOutOfRangeException("Array is empty.");
                case 1: case 2:
                    throw new InsufficientDataSetException("Data set not large enough to calculate an inter-quartile range");
            }

            var lowerQuart = LowerQuartile(a);
            var upperQuart = UpperQuartile(a);
            return upperQuart - lowerQuart;
        }

        /// <summary>
        /// Finds the inter-quartile range of the array.
        /// </summary>
        /// <param name="a">The array of type double</param>
        /// <returns>The inter-quartile range of all the elements in the array</returns>
        public static double InterQuartileRange(this double[] a)
        {
            if (a == null)
            {
                throw new NullReferenceException();
            }
            else switch (a.Length)
            {
                case 0:
                    throw new IndexOutOfRangeException("Array is empty.");
                case 1: case 2:
                    throw new InsufficientDataSetException("Data set not large enough to calculate an inter-quartile range");
            }

            var lowerQuart = LowerQuartile(a);
            var upperQuart = UpperQuartile(a);
            return upperQuart - lowerQuart;
        }

        /// <summary>
        /// Returns whether if the data set is normally distributed for a proportion.
        /// </summary>
        /// <param name="a">The array of type byte</param>
        /// <param name="samstat">The sample statistic</param>
        /// <returns>Returns whether if the data set is normally distributed for a proportion.</returns>
        public static bool IsNormalProp(byte[] a, double samstat)
        {
            if(a == null)
            {
                throw new NullReferenceException();
            }
            if(a.Length == 0)
            {
                return false;
            }

            if ((a.Length * samstat) <= 15) return false;
            if ((a.Length * (1 - samstat)) <= 15) return false;
            
            return true;
        }

        /// <summary>
        /// Returns whether if the data set is normally distributed for a proportion.
        /// </summary>
        /// <param name="a">The array of type short</param>
        /// <param name="samstat">The sample statistic</param>
        /// <returns>Returns whether if the data set is normally distributed for a proportion.</returns>
        public static bool IsNormalProp(short[] a, double samstat)
        {
            if(a == null)
            {
                throw new NullReferenceException();
            }
            if(a.Length == 0)
            {
                return false;
            }

            if ((a.Length * samstat) <= 15) return false;
            if ((a.Length * (1 - samstat)) <= 15) return false;
            
            return true;
        }

        /// <summary>
        /// Returns whether if the data set is normally distributed for a proportion.
        /// </summary>
        /// <param name="a">The array of type int</param>
        /// <param name="samstat">The sample statistic</param>
        /// <returns>Returns whether if the data set is normally distributed for a proportion.</returns>
        public static bool IsNormalProp(int[] a, double samstat)
        {
            if(a == null)
            {
                throw new NullReferenceException();
            }
            if(a.Length == 0)
            {
                return false;
            }

            if ((a.Length * samstat) <= 15) return false;
            if ((a.Length * (1 - samstat)) <= 15) return false;
            
            return true;
        }

        /// <summary>
        /// Returns whether if the data set is normally distributed for a proportion.
        /// </summary>
        /// <param name="a">The array of type long</param>
        /// <param name="samstat">The sample statistic</param>
        /// <returns>Returns whether if the data set is normally distributed for a proportion.</returns>
        public static bool IsNormalProp(long[] a, double samstat)
        {
            if(a == null)
            {
                throw new NullReferenceException();
            }
            if(a.Length == 0)
            {
                return false;
            }

            if ((a.Length * samstat) <= 15) return false;
            if ((a.Length * (1 - samstat)) <= 15) return false;
            
            return true;
        }

        /// <summary>
        /// Returns whether if the data set is normally distributed for a proportion.
        /// </summary>
        /// <param name="a">The array of type float</param>
        /// <param name="samstat">The sample statistic</param>
        /// <returns>Returns whether if the data set is normally distributed for a proportion.</returns>
        public static bool IsNormalProp(float[] a, double samstat)
        {
            if(a == null)
            {
                throw new NullReferenceException();
            }
            if(a.Length == 0)
            {
                return false;
            }
            if ((a.Length * samstat) <= 15) return false;
            if ((a.Length * (1 - samstat)) <= 15) return false;
            
            return true;
        }

        /// <summary>
        /// Returns whether if the data set is normally distributed for a proportion.
        /// </summary>
        /// <param name="a">The array of type double</param>
        /// <param name="samstat">The sample statistic</param>
        /// <returns>Returns whether if the data set is normally distributed for a proportion.</returns>
        public static bool IsNormalProp(double[] a, double samstat)
        {
            if(a == null)
            {
                throw new NullReferenceException();
            }
            if(a.Length == 0)
            {
                return false;
            }
            if ((a.Length * samstat) <= 15) return false;
            if ((a.Length * (1 - samstat)) <= 15) return false;
            
            return true;
        }

        /// <summary>
        /// Returns whether if the data set is normally distributed for a mean.
        /// </summary>
        /// <param name="a">The array of type byte</param>
        /// <param name="samstat">The sample statistic</param>
        /// <returns>Returns whether if the data set is normally distributed for a mean.</returns>
        public static bool IsNormalMean(this byte[] a, double samstat)
        {
            if(a == null)
            {
                throw new NullReferenceException();
            }
            return !(Math.Abs(Mode(a)) > TOLERANCE);
        }

        /// <summary>
        /// Returns whether if the data set is normally distributed for a mean.
        /// </summary>
        /// <param name="a">The array of type short</param>
        /// <param name="samstat">The sample statistic</param>
        /// <returns>Returns whether if the data set is normally distributed for a mean.</returns>
        public static bool IsNormalMean(this short[] a, double samstat)
        {
            if(a == null)
            {
                throw new NullReferenceException();
            }
            return !(Math.Abs(Mode(a)) > TOLERANCE);
        }

        /// <summary>
        /// Returns whether if the data set is normally distributed for a mean.
        /// </summary>
        /// <param name="a">The array of type int</param>
        /// <param name="samstat">The sample statistic</param>
        /// <returns>Returns whether if the data set is normally distributed for a mean.</returns>
        public static bool IsNormalMean(this int[] a, double samstat)
        {
            if(a == null)
            {
                throw new NullReferenceException();
            }
            return !(Math.Abs(Mode(a)) > TOLERANCE);
        }

        /// <summary>
        /// Returns whether if the data set is normally distributed for a mean.
        /// </summary>
        /// <param name="a">The array of type long</param>
        /// <param name="samstat">The sample statistic</param>
        /// <returns>Returns whether if the data set is normally distributed for a mean.</returns>
        public static bool IsNormalMean(this long[] a, double samstat)
        {
            if(a == null)
            {
                throw new NullReferenceException();
            }
            return !(Math.Abs(Mode(a)) > TOLERANCE);
        }

        /// <summary>
        /// Returns whether if the data set is normally distributed for a mean.
        /// </summary>
        /// <param name="a">The array of type float</param>
        /// <param name="samstat">The sample statistic</param>
        /// <returns>Returns whether if the data set is normally distributed for a mean.</returns>
        public static bool IsNormalMean(this float[] a, double samstat)
        {
            if(a == null)
            {
                throw new NullReferenceException();
            }
            return !(Math.Abs(Mode(a)) > TOLERANCE);
        }

        /// <summary>
        /// Returns whether if the data set is normally distributed for a mean.
        /// </summary>
        /// <param name="a">The array of type double</param>
        /// <param name="samstat">The sample statistic</param>
        /// <returns>Returns whether if the data set is normally distributed for a mean.</returns>
        public static bool IsNormalMean(this double[] a, double samstat)
        {
            if(a == null)
            {
                throw new NullReferenceException();
            }
            return !(Math.Abs(Mode(a)) > TOLERANCE);
        }

        /// <summary>
        /// Creates confidence interval for the given data set
        /// </summary>
        /// <param name="mean">The mean of the data set</param>
        /// <param name="cv">The critical value of the data set</param>
        /// <param name="se">The standard error of the data set</param>
        /// <returns>Returns a confidence interval of the data set.</returns>
        public static double[] CreateConfidenceInterval(double mean, double cv, double se)
        {
            var ci = new double[2];
            var lowBound = mean - (cv * se);
            var upperBound = mean + (cv * se);
            ci[0] = lowBound;
            ci[1] = upperBound;

            return ci;
        }

        /// <summary>
        /// Returns whether if the data set is normally distributed for a mean.
        /// </summary>
        /// <param name="mean">The mean of the data set</param>
        /// <param name="popMean">The population mean</param>
        /// <param name="stdDev">The standard deviation of the data set</param>
        /// <param name="size">The size of the data set</param>
        /// <returns>Constructs the t-critical value</returns>
        public static double ConstructTValue(double mean, double popMean, double stdDev, double size)
        {
            var t = ((mean - popMean) / (stdDev / Math.Sqrt(size)));
            return t;
        }

    }//ArrayStatUtils

}//namespace Utilities
