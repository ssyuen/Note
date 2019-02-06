using System;
using System.Runtime.InteropServices;
using Utilities;

public class Driver
{
    public static void Main(string[] args)
    {
        Console.WriteLine(StringUtils.Remove("Manu", 'u', 'M'));
        Console.WriteLine(StringUtils.Chomp("Manu Puduvalli"));
        Console.WriteLine(StringUtils.ChompAfter("A long rainy day is in the midst", 0));
        Console.WriteLine(StringUtils.IsPalindromeIgnoreCase("malayalam"));
        Console.WriteLine(StringUtils.IsStrictlyIncreasing("1234"));
        Console.WriteLine(StringUtils.Remove("Manu", 'a'));
        Console.WriteLine(StringUtils.Chomp($"Hello Sam"));

        
        //TESTING ARRAYUTILS.CONCAT
        
        //int array concat
        int[] array1 = {1, 2, 3, 4};
        int[] array2 = {5, 6, 7, 8};
        int[] array3 = ArrayGeneralUtils.Concat(array1, array2);
        foreach (var e in array3)
        {
            Console.WriteLine(e);
        }

        //string array concat
        string[] firstName = {"sam", "glen", "lok", "manu"};
        string[] lastName = {"yuen", "george", "kwong", "puduvalli"};
        string[] fullName = ArrayGeneralUtils.Concat(firstName, lastName);
        foreach (var e in fullName)
        {
            Console.WriteLine(e);
        }
        
        //TESTING ARRAYUTILS.FINDAVG
        double[] array4 = {4, 7, 2.3, 5, 7, 3.0};

        Console.WriteLine(ArrayUtils.Mean(array4));

        //END TESTING ARRAYUTILS.FINDAVG

        Console.Read();
    }
}
