using System;
using System.Linq;
using System.Text;

public sealed class StringUtils
{
    /// <summary>
    /// Reverses a string from left to right order while maintaining case sensitivity.
    /// </summary>
    /// <param name="str"></param>
    /// <returns>The reversed string</returns>
    public static string Reverse(string str)
    {
        char[] c = str.ToCharArray();
        Array.Reverse(c);
        return new string(c);
    }
    /// <summary>
    /// Creates a string from the first character of the string to the first whitespace.
    /// </summary>
    /// <param name="str"></param>
    /// <returns>The string retaining the first word</returns>
    public static string Chomp(string str)
    {
        int idx = str.IndexOf(" ");
        return str.Substring(0, idx);
    }

    /// <summary>
    /// Removes all instances of any number of characters from a string.
    /// </summary>
    /// <param name="str"></param>
    /// <param name="args"></param>
    /// <returns>The string with all characters in args removed</returns>
    public static string Remove(string str, params char[] args)
    {
        StringBuilder sb = new StringBuilder(str);
        foreach (char c in args)
        {
            sb.Replace(c.ToString(), "");
        }

        return sb.ToString();
    }

    /// <summary>
    /// Checks if a given string contains any digits.
    /// </summary>
    /// <param name="str"></param>
    /// <returns>True if the string contains any digits, false otherwise</returns>
    public static bool ContainsDigits(string str)
    {
        return str.Any(char.IsDigit);
    }

    
}