using System;
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
        Console.Read();
    }
}
