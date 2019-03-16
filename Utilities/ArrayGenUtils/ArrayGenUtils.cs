using System;
using System.Linq;
using System.Text;

namespace Utilities
{
    /// <summary>
    /// An array utility class
    /// </summary>
    public static class ArrayGenUtils
    {

        /// <summary>
        /// Concatenates two arrays of the same type together.
        /// </summary>
        /// <param name="array1">The first array to be concatenated</param>
        /// <param name="array2">The second array to be concatenated</param>
        /// <exception cref="ArgumentNullException">Thrown when the array is null</exception>
        /// <returns>The concatenated array</returns>
        public static T[] Concat <T> (T[] array1, T[] array2)
        {
            if (array1 == null || array2 == null)
            {
                throw new ArgumentNullException();
            }
            var z = new T[array1.Length + array2.Length];

            /*
             *copyTo method is optimized for these scenarios.
             * Most exceptions are also caught and thrown in the copyTo method
             */
            array1.CopyTo(z, 0);
            array2.CopyTo(z, array1.Length);
            return z;
        } //array concat


        /// <summary>
        /// Adds all the values in an array.
        /// </summary>
        /// <param name="arr">the array of type byte</param>
        /// <exception cref="ArgumentNullException">Thrown when the array is null</exception>
        /// <returns>The added amount</returns>
        public static double AddAll(this byte[] arr)
        {
            if(arr == null)
            {
                throw new ArgumentNullException();
            }
            if(arr.Length == 1)
            {
                return arr[0];
            }
            var arr_mult_tot = arr.Aggregate(1, (idx1, idx2) => idx1 * idx2);
            return arr_mult_tot;
        }

        /// <summary>
        /// Adds all the values in an array.
        /// </summary>
        /// <param name="arr">the array of type short</param>
        /// <exception cref="ArgumentNullException">Thrown when the array is null</exception>
        /// <returns>The added amount</returns>
        public static double AddAll(this short[] arr)
        {
            if(arr == null)
            {
                throw new ArgumentNullException();
            }
            if(arr.Length == 1)
            {
                return arr[0];
            }
            var arr_mult_tot = arr.Aggregate(0, (idx1, idx2) => idx1 + idx2);
            return arr_mult_tot;
        }

        /// <summary>
        /// Adds all the values in an array.
        /// </summary>
        /// <param name="arr">the array of type int</param>
        /// <exception cref="ArgumentNullException">Thrown when the array is null</exception>
        /// <returns>The added amount</returns>
        public static double AddAll(this int[] arr)
        {
            if(arr == null)
            {
                throw new ArgumentNullException();
            }
            if(arr.Length == 1)
            {
                return arr[0];
            }
            var arr_mult_tot = arr.Aggregate(0, (idx1, idx2) => idx1 + idx2);
            return arr_mult_tot;
        }

        /// <summary>
        /// Adds all the values in an array.
        /// </summary>
        /// <param name="arr">the array of type int</param>
        /// <exception cref="ArgumentNullException">Thrown when the array is null</exception>
        /// <returns>The added amount</returns>
        public static double AddAll(this long[] arr)
        {
            if(arr == null)
            {
                throw new ArgumentNullException();
            }
            if(arr.Length == 1)
            {
                return arr[0];
            }
            double arr_mult_tot = 1;
            for(int i = 0 ; i < arr.Length; i++)
            {
               arr_mult_tot += arr[i];
            }
            return arr_mult_tot;
        }

        /// <summary>
        /// Adds all the values in an array.
        /// </summary>
        /// <param name="arr">the array of type float</param>
        /// <exception cref="ArgumentNullException">Thrown when the array is null</exception>
        /// <returns>The added amount</returns>
        public static double AddAll(this float[] arr)
        {
            if(arr == null)
            {
                throw new ArgumentNullException();
            }
            if(arr.Length == 1)
            {
                return arr[0];
            }
            float arr_mult_tot = 1F;
            for(int i = 0 ; i < arr.Length; i++)
            {
               arr_mult_tot += arr[i];
            }
            return arr_mult_tot;
        }

        /// <summary>
        /// Subtracts all the values in an array.
        /// </summary>
        /// <param name="arr">the array of type byte</param>
        /// <exception cref="ArgumentNullException">Thrown when the array is null</exception>
        /// <returns>The subtracted amount</returns>
        public static double SubtractAll(this byte[] arr)
        {
            if(arr == null)
            {
                throw new ArgumentNullException();
            }
            if(arr.Length == 1)
            {
                return arr[0];
            }
            var arr_mult_tot = arr.Aggregate(0, (idx1, idx2) => idx1 - idx2);
            return arr_mult_tot;
        }

        /// <summary>
        /// Subtracts all the values in an array.
        /// </summary>
        /// <param name="arr">the array of type short</param>
        /// <exception cref="ArgumentNullException">Thrown when the array is null</exception>
        /// <returns>The subtracted amount</returns>
        public static double SubtractAll(this short[] arr)
        {
            if(arr == null)
            {
                throw new ArgumentNullException();
            }
            if(arr.Length == 1)
            {
                return arr[0];
            }
            var arr_mult_tot = arr.Aggregate(0, (idx1, idx2) => idx1 - idx2);
            return arr_mult_tot;
        }

        /// <summary>
        /// Subtracts all the values in an array.
        /// </summary>
        /// <param name="arr">the array of type int</param>
        /// <exception cref="ArgumentNullException">Thrown when the array is null</exception>
        /// <returns>The subtracted amount</returns>
        public static double SubtractAll(this int[] arr)
        {
            if(arr == null)
            {
                throw new ArgumentNullException();
            }
            if(arr.Length == 1)
            {
                return arr[0];
            }
            var arr_mult_tot = arr.Aggregate(0, (idx1, idx2) => idx1 - idx2);
            return arr_mult_tot;
        }

        /// <summary>
        /// Subtracts all the values in an array.
        /// </summary>
        /// <param name="arr">the array of type long</param>
        /// <exception cref="ArgumentNullException">Thrown when the array is null</exception>
        /// <returns>The subtracted amount</returns>
        public static double SubtractAll(this long[] arr)
        {
            if(arr == null)
            {
                throw new ArgumentNullException();
            }
            if(arr.Length == 1)
            {
                return arr[0];
            }
            double arr_mult_tot = 1;
            for(int i = 0 ; i < arr.Length; i++)
            {
               arr_mult_tot -= arr[i];
            }
            return arr_mult_tot;
        }

        /// <summary>
        /// Subtracts all the values in an array.
        /// </summary>
        /// <param name="arr">the array of type float</param>
        /// <exception cref="ArgumentNullException">Thrown when the array is null</exception>
        /// <returns>The subtracted amount</returns>
        public static double SubtractAll(this float[] arr)
        {
            if(arr == null)
            {
                throw new ArgumentNullException();
            }
            if(arr.Length == 1)
            {
                return arr[0];
            }
            float arr_mult_tot = 1F;
            for(int i = 0 ; i < arr.Length; i++)
            {
               arr_mult_tot -= arr[i];
            }
            return arr_mult_tot;
        }

        /// <summary>
        /// Allocates spaces in the array after a specified index. Spaces can be inserted after the first index
        /// of the array (index 0) and before the last index of the array (arr.Length - 1). For inserting spaces
        /// before the first index or after the last index of the array, refer to the seealso. The empty indexes
        /// are filled with the default value type for the array. Optionally, empty indexes in the new array
        /// can be filled through a variable argument array.
        /// </summary>
        /// <typeparam name="T">The type of the array</typeparam>
        /// <param name="arr">The array to be used</param>
        /// <param name="offset">The amount of spaces to create in the array</param>
        /// <param name="startingIndexOfOffset">The index to start the spaces AFTER</param>
        /// <param name="offsetPointValues">Optionally, the values to insert into the empty indexes of the new array</param>
        /// <returns>A new array with the specified allocations</returns>
        /// <exception cref="IndexOutOfRangeException">Thrown when the offsetPointValues array does not match the amount of offsets (if it is greater than 0)</exception>
        /// <exception cref="IndexOutOfRangeException">Thrown when the offset or the startingIndexOffset is less than 0</exception>
        /// <example>This sample shows how to call the <see cref="ArrayGenUtils.InsertIntoManaged{T}(T[], int, int, T[])"/> method.</example>
        /// <code>
        /// class TestClass
        /// {
        ///     static int Main(string[] args)
        ///     {
        ///         int[] w = new int[9] {2, 3, 4, 5, 6, 7, 8, 9, 10};
        ///         int[] x = w.InsertIntoManaged(3, 1);
        ///         //Printint out x results in: 2, 3, 0, 0, 0, 4, 5, 6, 7, 8, 9, 10
        ///
        ///         int[] y = new int[9] {2, 3, 4, 5, 6, 7, 8, 9, 10};
        ///         int[] z = y.InsertIntoManaged(3, 1, 250, 350, 450);
        ///         //Printing out z results in: 2, 3, 250, 350, 450, 4, 5, 6, 7, 8, 9, 10
        ///     }
        /// }
        /// </code>
        /// <seealso cref="ArrayGenUtils.ShiftBeginningToRightManaged{T}(T[], int, T[])"/>
        /// <seealso cref="ArrayGenUtils.ShiftEndToLeftManaged{T}(T[], int, T[])"/>
        public static T[] InsertIntoManaged<T>(this T[] arr, int offset, int startingIndexOfOffset, params T[] offsetPointValues)
        {

            if (startingIndexOfOffset < 0 || startingIndexOfOffset >= arr.Length || offset < 0)
            {
                throw new IndexOutOfRangeException();
            }
            if(offsetPointValues.Length != 0 && offset != offsetPointValues.Length)
            {
                throw new IndexOutOfRangeException("offset amount should equal the number of values to be filled");
            }
            T[] arr_managed = new T[arr.Length + offset];
            Array.ConstrainedCopy(arr, 0, arr_managed, 0, startingIndexOfOffset + 1);
            Array.ConstrainedCopy(offsetPointValues, 0, arr_managed, startingIndexOfOffset + 1, offsetPointValues.Length);
            Array.ConstrainedCopy(arr, startingIndexOfOffset + 1, arr_managed, startingIndexOfOffset + offset + 1, arr.Length - (startingIndexOfOffset + 1));
            for(int i = startingIndexOfOffset + 1; i < startingIndexOfOffset + offset; i++)
            {
                arr_managed[i] = default(T);
            }
            return arr_managed;
        }

        /// <summary>
        /// Allocates spaces in the array before the first index of the array. Essentially, the array is shifted to the
        /// right. For inserting spaces in between index values in the array, refer to the seealso. The empty indexes
        /// are filled with the default value type for the array. Optionally, empty indexes in the new array
        /// can be filled through a variable argument array.
        /// </summary>
        /// <typeparam name="T">The type of the array</typeparam>
        /// <param name="arr">The array to be used</param>
        /// <param name="offset">The amount of spaces to create in the array</param>
        /// <param name="offsetPointValues">Optionally, the values to insert into the empty indexes of the new array</param>
        /// <returns>A new array with the specified allocations</returns>
        /// <exception cref="IndexOutOfRangeException">Thrown when the offsetPointValues array does not match the amount of offset (if it is greater than 0)</exception>
        /// <exception cref="IndexOutOfRangeException">Thrown when the offset is less than 0</exception>
        /// <example>This sample shows how to call the <see cref="ArrayGenUtils.ShiftBeginningToRightManaged{T}(T[], int, T[])"/> method.</example>
        /// <code>
        /// class TestClass
        /// {
        ///     static int Main(string[] args)
        ///     {
        ///         int[] w = new int[9] {2, 3, 4, 5, 6, 7, 8, 9, 10};
        ///         int[] x = w.ShiftBeginningToRightManaged(3);
        ///         //Printint out x results in: 0, 0, 0, 2, 3, 4, 5, 6, 7, 8, 9, 10
        ///
        ///         int[] y = new int[9] {2, 3, 4, 5, 6, 7, 8, 9, 10};
        ///         int[] z = y.ShiftBeginningToRightManaged(3, 250, 350, 450);
        ///         //Printing out z results in: 250, 350, 450, 2, 3, 4, 5, 6, 7, 8, 9, 10
        ///     }
        /// }
        /// </code>
        /// <seealso cref="ArrayGenUtils.InsertIntoManaged{T}(T[], int, int, T[])"/>
        /// <seealso cref="ArrayGenUtils.ShiftEndToLeftManaged{T}(T[], int, T[])"/>
        public static T[] ShiftBeginningToRightManaged<T>(this T[] arr, int offset, params T[] offsetPointValues)
        {

            if (offset < 0)
            {
                throw new IndexOutOfRangeException();
            }
            if(offsetPointValues.Length != 0 && offset != offsetPointValues.Length)
            {
                throw new IndexOutOfRangeException("offset amount should equal the number of values to be filled");
            }
            T[] arr_managed = new T[arr.Length + offset];

            Array.ConstrainedCopy(offsetPointValues, 0, arr_managed, 0, offsetPointValues.Length);
            Array.ConstrainedCopy(arr, 0, arr_managed, offset, arr.Length);
            for (int i = 0 + 1; i < offset; i++)
            {
                arr_managed[i] = default(T);
            }
            return arr_managed;
        }

        /// <summary>
        /// Allocates spaces in the array after the last index of the array. Essentially, the array is shifted to the left
        /// from the end. For inserting spaces in between index values in the array, refer to the seealso. The empty indexes
        /// are filled with the default value type for the array. Optionally, empty indexes in the new array
        /// can be filled through a variable argument array.
        /// </summary>
        /// <typeparam name="T">The type of the array</typeparam>
        /// <param name="arr">The array to be used</param>
        /// <param name="offset">The amount of spaces to create in the array</param>
        /// <param name="offsetPointValues">Optionally, the values to insert into the empty indexes of the new array</param>
        /// <returns>A new array with the specified allocations</returns>
        /// <exception cref="IndexOutOfRangeException">Thrown when the offsetPointValues array does not match the amount of offset (if it is greater than 0)</exception>
        /// <exception cref="IndexOutOfRangeException">Thrown when the offset is less than 0</exception>
        /// <example>This sample shows how to call the <see cref="ArrayGenUtils.ShiftBeginningToRightManaged{T}(T[], int, T[])"/> method.</example>
        /// <code>
        /// class TestClass
        /// {
        ///     static int Main(string[] args)
        ///     {
        ///         int[] w = new int[9] {2, 3, 4, 5, 6, 7, 8, 9, 10};
        ///         int[] x = w.ShiftEndToLeftManaged(3);
        ///         //Printint out x results in: 2, 3, 4, 5, 6, 7, 8, 9, 10, 0, 0, 0
        ///
        ///         int[] y = new int[9] {2, 3, 4, 5, 6, 7, 8, 9, 10};
        ///         int[] z = y.ShiftEndToLeftManaged(3, 250, 350, 450);
        ///         //Printing out z results in: 2, 3, 4, 5, 6, 7, 8, 9, 10, 250, 350, 450
        ///     }
        /// }
        /// </code>
        /// <seealso cref="ArrayGenUtils.InsertIntoManaged{T}(T[], int, int, T[])"/>
        /// <seealso cref="ArrayGenUtils.ShiftBeginningToRightManaged{T}(T[], int, T[])"/>
        public static T[] ShiftEndToLeftManaged<T>(this T[] arr, int offset, params T[] offsetPointValues)
        {
            if (offset < 0)
            {
                throw new IndexOutOfRangeException();
            }
            if (offsetPointValues.Length != 0 && offset != offsetPointValues.Length)
            {
                throw new IndexOutOfRangeException("offset amount should equal the number of values to be filled");
            }
            T[] arr_managed = new T[arr.Length + offset];

            Array.ConstrainedCopy(offsetPointValues, 0, arr_managed, arr_managed.Length - offset, offsetPointValues.Length);
            Array.ConstrainedCopy(arr, 0, arr_managed, 0, arr.Length);
            for (int i = arr.Length; i < arr_managed.Length; i++)
            {
                arr_managed[i] = default(T);
            }
            return arr_managed;
        }

        /// <summary>
        /// Prints a string representation of an array. There are 4 supported lengths for the formattingRegex. The
        /// default length is 0 and the default behavior depends on the type of the array. If the type is primitive
        /// (based on the System.IsPrimitive property) including decimal and string, then it prints the array with a space
        /// as a separator between each element. If the array is not primitive, it prints the array with no separator.
        /// A formattingRegex of length 1 specifies a character to separate each element. The array is printed out, following
        /// a default behavior, execpt with the specified separator rather than the default separator. A formattingRegex
        /// of length 2 specifies a two characters to mark the left and right outer bounds of the array, A formattingRegex
        /// of length 3 specifies a character for the left outer bound of the array, followed by a separator character,
        /// followed by a character for the right outer bound of the array. If no separator is desired, the "/0+" regex
        /// can be specified.The evenlySpacedSeparator parameter specifies whether an even number of spaces should be on
        /// both sides of the separator. This parameter ignores Object type arrays excluding decimal and string.
        /// </summary>
        /// <typeparam name="T">The type of the array</typeparam>
        /// <param name="arr">The array to be used</param>
        /// <param name="formattingRegex">The guidelined regex to be optionally used</param>
        /// <param name="evenlySpacedSeparator">Determines whether the spacing between each element should be the same</param>
        /// <returns>The string representation of the array</returns>
        /// <exception cref="ArgumentException">If arr is null</exception>
        /// <exception cref="FormatException">If the formatting regex length is neither 0 or 3</exception>
        /// <example>This sample shows how to call the <see cref="ToStringExt{T}(T[], string, bool)"/> method.</example>
        /// <code>
        /// class TestClass
        /// {
        ///     static int Main(string[] args)
        ///     {
        ///         int[] w = new int[9] {2, 3, 4, 5, 6, 7, 8, 9, 10};
        ///         Console.WriteLine(w.ToStringExt("[,]"));
        ///         //The above results in: [2, 3, 4, 5, 6, 7, 8, 9, 10]
        ///
        ///         int[] x = new int[9] {2, 3, 4, 5, 6, 7, 8, 9, 10};
        ///         Console.WriteLine(x.ToStringExt("(|)", true));
        ///         //Printing out z results in: (2 | 3 | 4 | 5 | 6 | 7 | 8 | 9 | 10)
        ///
        ///         string[] y = new string[4] {"Bill", "Bob", "Tom", "Joe"};
        ///         Console.WriteLine(y.ToStringExt());
        ///         //Printing out y results in: Bill Bob Tom Joe
        ///     }
        /// }
        /// </code>
        public static string ToStringExt<T>(this T[] arr, string formattingRegex = "", bool evenlySpacedSeparator = false)
        {
            int frl = formattingRegex.Length;

            if (arr == null)
            {
                throw new ArgumentNullException("array");
            }
            if (frl < 0 || frl > 3)
            {
                throw new FormatException("Unsupported Regular Expression");
            }
            string outerLeft = string.Empty, separator = string.Empty, outerRight = string.Empty;
            bool hasNoSep = false;
            if (formattingRegex.Equals("/0+"))
            {
                hasNoSep = true;
                frl = 1;
            }

            switch (frl)
            {
                case 3:
                    outerLeft = formattingRegex[0].ToString();
                    separator = formattingRegex[1].ToString();
                    outerRight = formattingRegex[2].ToString();
                    break;

                case 2:
                    outerLeft = formattingRegex[0].ToString();
                    outerRight = formattingRegex[1].ToString();
                    break;

                case 1:
                    separator = formattingRegex[0].ToString();
                    break;
            }

            bool isLooselyPrimitive = false;
            Type T_type = typeof(T);
            if (T_type.IsPrimitive || T_type == typeof(decimal) || T_type == typeof(string))
            {
                isLooselyPrimitive = true;
            }

            StringBuilder sb = new StringBuilder();
            sb.Append(outerLeft);
            for (int i = 0; i < arr.Length; i++)
            {
                if(i == arr.Length - 1)
                {
                    sb.Append(arr[i]);
                }
                else switch(frl)
                {
                    case 0:
                    case 2:
                    case 3: defBehavior:
                            if (evenlySpacedSeparator && isLooselyPrimitive)
                            {
                                if (frl != 2)
                                {
                                    sb.Append(arr[i] + " " + separator + " ");
                                }
                                else
                                {
                                    sb.Append(arr[i] + separator + " ");
                                }
                            }
                            else if (isLooselyPrimitive)
                            {
                                sb.Append(arr[i] + separator + " ");
                            }
                            else
                            {
                                sb.Append(arr[i] + separator);
                            }
                        break;

                    case 1:
                        if (hasNoSep)
                            sb.Append(arr[i]);
                        else
                            goto defBehavior;
                        break;
                }
            }
            sb.Append(outerRight);
            return sb.ToString();
        }
    }//ArrayUtils
}//Namespace
