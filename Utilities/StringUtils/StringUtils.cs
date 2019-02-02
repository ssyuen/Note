using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Utilities
{
    public static class StringUtils
    {
        /// <summary>
        /// Reverses a string from left to right order while maintaining case sensitivity.
        /// </summary>
        /// <param name="str">The string to be reversed</param>
        /// <returns>The reversed string</returns>
        public static string Reverse(this string str)
        {
            char[] c = str.ToCharArray();
            Array.Reverse(c);
            return new string(c);
        }
        /// <summary>
        /// Creates a string from the first character of the string to the first whitespace.
        /// </summary>
        /// <param name="str">The string to be chomped</param>
        /// <returns>The string retaining the first word</returns>
        public static string Chomp(this string str)
        {
            int idx = str.IndexOf(" ");
            return str.Substring(0, idx);
        }

        /// <summary>
        /// Removes all instances of any number of characters from a string.
        /// </summary>
        /// <param name="str">The string to be used</param>
        /// <param name="args">The characters which will be removed</param>
        /// <returns>The string with all characters in args removed</returns>
        public static string Remove(this string str, params char[] args)
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
        /// <param name="str">The string to be used</param>
        /// <returns>True if the string contains any digits, false otherwise</returns>
        public static bool ContainsDigits(this string str)
        {
            return str.Any(char.IsDigit);
        }

        /// <summary>
        /// Roughly mimics C style strings in that each character of the specified string is stored in a List
        /// </summary>
        /// <param name="str">The string to be used</param>
        /// <returns>The string represented as a List</returns>
        public static List<char> ToList(this string str)
        {
            List<char> strcpy_list = new List<char>(str.Length);
            foreach (char c in strcpy_list)
            {
                strcpy_list.Add(c);
            }
            return strcpy_list;
        }

        /// <summary>
        /// Checks if a given string is a valid date used by System.DateTime
        /// </summary>
        /// <param name="str">The string to be used</param>
        /// <param name="format">The date format regex</param>
        /// <returns>True if the string is a valid date recognized by System.DateTime</returns>
        public static bool IsSystemDateTime(this string date, string formattingRegex)
        {
            return DateTime.TryParseExact(date, formattingRegex, CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime dt);
        }

        /// <summary>
        /// Checks if a given string is a palindrome
        /// </summary>
        /// <param name="str">The string to be used</param>
        /// <returns>True if the string is a palindrome</returns>
        public static bool IsPalindrome(this string str)
        {
            if (str.Length >= Int32.MaxValue) return false;
            for (Int32 advancing = 0; advancing < str.Length; advancing++)
            {
                Int32 retrograding = str.Length - 1 - advancing;
                if (!(str[advancing] == str[retrograding])) return false;
            }
            return true;
        }

        /// <summary>
        /// Checks if a given string is a palindrom while ignoring casing
        /// </summary>
        /// <param name="str">The string to be used</param>
        /// <returns>True if the string is a palindrome</returns>
        public static bool IsPalindromeIgnoreCase(this string str)
        {
            if (str.Length >= Int32.MaxValue) return false;
            str = str.ToLower();
            for (Int32 advancing = 0; advancing < str.Length; advancing++)
            {
                Int32 retrograding = str.Length - 1 - advancing;
                if (!(str[advancing] == str[retrograding])) return false;
            }
            return true;
        }
    }
}