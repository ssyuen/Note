using System;
using Utilities;

public class Driver
{
    public static void Main(string[] args)
    {
        Console.WriteLine(StringUtils.Remove("Manu", 'u', 'M'));
        Console.WriteLine(StringUtils.IsPalindromeIgnoreCase("malayalam"));
        Console.WriteLine(StringUtils.IsStrictlyIncreasing("1234"));
        Console.Read();
    }
}
