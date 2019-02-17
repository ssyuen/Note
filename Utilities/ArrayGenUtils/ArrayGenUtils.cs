using System;
using System.Linq;

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
        /// Adds all the values in an array.
        /// </summary>
        /// <param name="arr">the array of type byte</param>
        /// <returns>The added amount</returns>
        public static double AddAll(this byte[] arr)
        {
            if(arr == null)
            {
                throw new NullReferenceException();
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
        /// <returns>The added amount</returns>
        public static double AddAll(this short[] arr)
        {
            if(arr == null)
            {
                throw new NullReferenceException();
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
        /// <returns>The added amount</returns>
        public static double AddAll(this int[] arr)
        {
            if(arr == null)
            {
                throw new NullReferenceException();
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
        /// <returns>The added amount</returns>
        public static double AddAll(this long[] arr)
        {
            if(arr == null)
            {
                throw new NullReferenceException();
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
        /// <returns>The added amount</returns>
        public static double AddAll(this float[] arr)
        {
            if(arr == null)
            {
                throw new NullReferenceException();
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
        /// <returns>The subtracted amount</returns>
        public static double SubtractAll(this byte[] arr)
        {
            if(arr == null)
            {
                throw new NullReferenceException();
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
        /// <returns>The subtracted amount</returns>
        public static double SubtractAll(this short[] arr)
        {
            if(arr == null)
            {
                throw new NullReferenceException();
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
        /// <returns>The subtracted amount</returns>
        public static double SubtractAll(this int[] arr)
        {
            if(arr == null)
            {
                throw new NullReferenceException();
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
        /// <returns>The subtracted amount</returns>
        public static double SubtractAll(this long[] arr)
        {
            if(arr == null)
            {
                throw new NullReferenceException();
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
        /// <returns>The subtracted amount</returns>
        public static double SubtractAll(this float[] arr)
        {
            if(arr == null)
            {
                throw new NullReferenceException();
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
        ///     static int Main() 
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
        ///     static int Main() 
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
        ///     static int Main() 
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
            return arr_managed;
        }
    }//ArrayUtils
}//Namespace
