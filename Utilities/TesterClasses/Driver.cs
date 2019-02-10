using System;
using System.Runtime.InteropServices;
using Utilities;

public class Driver
{
    public static void Main(string[] args)
    {
        Console.WriteLine(StringUtils.RemoveAll("Manu", 'u', 'M'));
        Console.WriteLine(StringUtils.Chomp("Manu Puduvalli"));
        Console.WriteLine(StringUtils.ChompAfter("A long rainy day is in the midst", 0));
        Console.WriteLine(StringUtils.IsPalindromeIgnoreCase("malayalam"));
        Console.WriteLine(StringUtils.IsStrictlyIncreasing("1234"));
        Console.WriteLine(StringUtils.RemoveAll("Manu", 'a'));
        Console.WriteLine(StringUtils.Chomp($"Hello Sam"));
        Console.WriteLine(StringUtils.RemoveAll("Manohar Jayakumar Puduvalli", "a", "k", "p"));
         
        
        //TESTING ARRAYGENERALUTILS.CONCAT
        
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
        
        //TESTING ARRAYSTATUTILS.MEAN
        double[] array4 = {4, 7, 2.3, 5, 7, 3.0};

        Console.WriteLine(ArrayStatUtils.Mean(array4));

        //END TESTING ARRAYSTATUTILS.MEAN
        
        
        //TESTING ARRAYSTATUTILS.MEDIAN
        int[] arrayl1 = {1};
        int[] arrayl0 = { };
        int[] arrayl2 = {1, 2};
        int[] arrayl3 = {1, 2, 3};
        int[] arrayl11 = {14, 4, 6, 51, 7, 25, 81, 3, 9, 68, 73};
        Console.WriteLine(ArrayStatUtils.Median(arrayl1));
        //Console.WriteLine(ArrayStatUtils.Median(arrayl0));
        Console.WriteLine(ArrayStatUtils.Median(arrayl2));
        Console.WriteLine(ArrayStatUtils.Median(arrayl3));
        Console.WriteLine(ArrayStatUtils.Median(arrayl11));
        //END TESTING ARRAYSTATUTILS.MEDIAN
        
        
        
        //TESTING ARRAYSTATUTILS.MODE
        Console.WriteLine("Testing Mode");
        int[] arrmode3 = {3, 2, 3, 3, 4, 6, 8};
        int[] arrnomode = {3, 3, 2, 2};
        Console.WriteLine(ArrayStatUtils.Mode(arrmode3));
        Console.WriteLine(ArrayStatUtils.Mode(arrnomode));
        
        Random r = new Random();
        var x = new int[10];
        for (var i = 0; i < x.Length; i++)
        {
            x[i] = r.Next(0, 10);
        }

        Console.WriteLine(ArrayStatUtils.Mode(x));
        
        //END TESTING ARRAYSTATUTILS.MODE
        
        
        //TESTING ARRAYSTATUTILS.STDDEV
        Console.WriteLine("Testing StdDev");
        int[] arrdev = {600, 470, 170, 430, 300};
        int[] arrdev2 = {1,2,3};
        int[] arrdev3 = { 4,9,11,12,17,5,8,12,14};
        Console.WriteLine(ArrayStatUtils.SampleStdDev(arrdev) + " is the sample std dev");
        Console.WriteLine(ArrayStatUtils.SampleStdDev(arrdev2) + " is the sample std dev");
        Console.WriteLine(ArrayStatUtils.SampleStdDev(arrdev3) + " is the sample std dev");
        
        Console.WriteLine(ArrayStatUtils.PopStdDev(arrdev) + " is the pop std dev");
        Console.WriteLine(ArrayStatUtils.PopStdDev(arrdev2) + " is the pop std dev");
        Console.WriteLine(ArrayStatUtils.PopStdDev(arrdev3) + " is the pop std dev");

        //END TESTING ARRAYSTATUTILS.STDDEV

        Console.Read();
    }
}
