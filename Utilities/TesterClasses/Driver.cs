using System;
using Utilities;

public class Driver
{
    public static void Main(string[] args)
    {
        Console.WriteLine(StringUtils.Remove("Manu", 'r'));
        Console.WriteLine(StringUtils.IsPalindromeIgnoreCase("malayala"));
        Console.WriteLine(StringUtils.IsStrictlyIncreasing("1243"));
        Console.Read();
    }
}
