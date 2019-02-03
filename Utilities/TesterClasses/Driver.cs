using System;
using System.Runtime.InteropServices;
using Utilities;

public class Driver
{
    public static void Main(string[] args)
    {
        Console.WriteLine(StringUtils.Remove("Manu", 'r'));
        Console.WriteLine(StringUtils.IsPalindromeIgnoreCase("malayalam"));
        Console.WriteLine(StringUtils.IsStrictlyIncreasing("1234"));

        Console.WriteLine(StringUtils.Remove("Manu", 'a'));
        
        Console.WriteLine(StringUtils.Chomp($"Hello Sam"));

        
        //TESTING ARRAYUTILS.CONCAT
        
        //int array concat
        int[] array1 = {1, 2, 3, 4};
        int[] array2 = {5, 6, 7, 8};
        int[] array3 = ArrayUtils<int>.Concat(array1, array2);
        foreach (var e in array3)
        {
            Console.WriteLine(e);
        }

        //string array concat
        string[] firstName = {"sam", "glen", "lok", "manu"};
        string[] lastName = {"yuen", "george", "kwong", "manuhar"};
        string[] fullName = ArrayUtils<string>.Concat(firstName, lastName);
        foreach (var e in fullName)
        {
            Console.WriteLine(e);
        }
        
        //
        object[] oArray = {array1, array2};
        object[] oArray2 = {firstName, lastName};
        object[] oArray3 = ArrayUtils<object>.Concat(oArray, oArray2);
        foreach (var e in oArray3)
        {
            Console.WriteLine(e);
        }
        //END TESTING ARRAYUTILS.CONCAT
        
        //TESTING ARRAYUTILS.FINDAVG
        Console.WriteLine(ArrayUtils<int>.FindAvg(array1));
        //END TESTING ARRAYUTILS.FINDAVG

        //Console.Read();
    }
}
