using System;

public class Driver
{
    protected static readonly Action<string> say = Console.WriteLine;

    public static void Main(string[] args)
    {
        say(StringUtils.Remove("Manu", 'r'));
        Console.Read();
    }
}
