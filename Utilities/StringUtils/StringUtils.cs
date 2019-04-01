using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Utilities.Attributes;

namespace Utilities
{
    [Author("Manu Puduvalli")]
    public static class StringUtils
    {

        /*
         * A string for a space character.
         *
         */
        private const string SPACE = " ";

        /// <summary>
        /// Reverses a string from left to right order while maintaining case sensitivity.
        /// </summary>
        /// <param name="str">The string to be reversed</param>
        /// <exception cref="ArgumentNullException">Thrown when the string is null</exception>
        /// <returns>The reversed string</returns>
        public static string Reverse(this string str)
        {
            if (str == null)
            {
                throw new ArgumentNullException();
            }
            if(str.Length == 0)
            {
                return string.Empty;
            }
            char[] c = str.ToCharArray();
            Array.Reverse(c);
            return new string(c);
        }

        /// <summary>
        /// Creates a string from the first character of the string to the first whitespace.
        /// </summary>
        /// <param name="str">The string to be chomped</param>
        /// <exception cref="ArgumentNullException">Thrown when the string is null</exception>
        /// <returns>The string retaining the first word</returns>
        public static string Chomp(this string str)
        {
            if (str == null)
            {
                throw new ArgumentNullException();
            }
            if (str.Length == 0)
            {
                return string.Empty;
            }
            int idx = str.IndexOf(SPACE);
            if(idx >= 0)
            {
                return str.Substring(0, idx);
            }
            else
            {
                return str;
            }
        }

        /// <summary>
        /// Creates a string from the first character of the string to the nth whitespace that is specified.
        /// </summary>
        /// <param name="str">The string to be chomped</param>
        /// <param name="spaces">The amount of white space to chomp after</param>
        /// <exception cref="ArgumentNullException">Thrown when the string is null</exception>
        /// <returns>The string retaining the chomped word</returns>
        public static string ChompAfter(this string str, int spaces)
        {
            if (str == null)
            {
                throw new ArgumentNullException();
            }
            if (str.Length == 0)
            {
                return string.Empty;
            }
            if (spaces != 0)
            {
                int index_of_space = 0;
                int matching_num_spaces = 0;
                for (int i = 0; i < str.Length; i++)
                {
                    if (char.IsWhiteSpace(str[i]))
                    {
                        index_of_space = i;
                        matching_num_spaces++;

                        if (spaces == matching_num_spaces)
                        {
                            return str.Substring(0, index_of_space);
                        }
                    }
                }
            }
            return str;
        }

        /// <summary>
        /// Counts the number of words in a string
        /// </summary>
        /// <param name="str">The string to be used</param>
        /// <exception cref="ArgumentNullException">Thrown when the string is null</exception>
        /// <returns>The number of words in the string</returns>
        public static int CountWords(this string str)
        {
            if (str == null)
            {
                throw new ArgumentNullException();
            }
            if (str.Length == 0)
            {
                return 0;
            }
            return str.Split().Length;
        }

        /// <summary>
        /// Removes all instances of any number of characters from a specified string.
        /// </summary>
        /// <param name="str">The string to be used</param>
        /// <param name="args">The characters which will be removed</param>
        /// <exception cref="ArgumentNullException">Thrown when the string is null</exception>
        /// <returns>The string with all characters in args removed</returns>
        public static string RemoveAll(this string str, params char[] args)
        {
            if (str == null || args == null)
            {
                throw new ArgumentNullException();
            }
            if (args.Length == 0)
            {
                return str;
            }
            if (str.Length == 0)
            {
                return string.Empty;
            }
            StringBuilder sb = new StringBuilder(str);
            for(int i = 0; i < args.Length; i++)
            {
                sb.Replace(args[i].ToString(), string.Empty);
            }
            return sb.ToString();
        }

        /// <summary>
        /// Removes all instances of any number of strings from a specified string.
        /// </summary>
        /// <param name="str">The string to be used</param>
        /// <param name="args">The characters which will be removed</param>
        /// <exception cref="ArgumentNullException">Thrown when the string is null</exception>
        /// <returns>The string with all characters in args removed</returns>
        public static string RemoveAll(this string str, params string[] args)
        {
            if (str == null || args == null)
            {
                throw new ArgumentNullException();
            }
            if (args.Length == 0)
            {
                return str;
            }
            if (str.Length == 0)
            {
                return string.Empty;
            }
            StringBuilder sb = new StringBuilder(str);
            
            for (int i = 0; i < args.Length; i++)
            {
                if(args[i].Length == 1)
                {
                    sb.Replace(args[i].ToString(), string.Empty);
                }
                else
                {
                    int idxOfWord = sb.ToString().IndexOf(args[i]);
                    sb.Remove(idxOfWord, args[i].Length);
                }
            }
            return sb.ToString();
        }

        /// <summary>
        /// Removes all instances of any number of characters from a specified string while ignoring case.
        /// </summary>
        /// <param name="str">The string to be used</param>
        /// <param name="args">The characters which will be removed</param>
        /// <exception cref="ArgumentNullException">Thrown when the string is null</exception>
        /// <returns>The string with all characters in args removed</returns>
        public static string RemoveAllIgnoreCase(this string str, params char[] args)
        {
            if (str == null || args == null)
            {
                throw new ArgumentNullException();
            }
            if (args.Length == 0)
            {
                return str;
            }
            if (str.Length == 0)
            {
                return string.Empty;
            }
            str += str.ToLower();
            StringBuilder sb = new StringBuilder(str);
            for (int i = 0; i < args.Length; i++)
            {
                sb.Replace(args[i].ToString(), string.Empty);
            }
            return sb.ToString();
        }

        /// <summary>
        /// Removes all instances of any number of strings from a specified string while ignoring case.
        /// </summary>
        /// <param name="str">The string to be used</param>
        /// <param name="args">The characters which will be removed</param>
        /// <exception cref="ArgumentNullException">Thrown when the string is null</exception>
        /// <returns>The string with all characters in args removed</returns>
        public static string RemoveAllIgnoreCase(this string str, params string[] args)
        {
            if (str == null || args == null)
            {
                throw new ArgumentNullException();
            }
            if(args.Length == 0)
            {
                return str;
            }
            if (str.Length == 0)
            {
                return string.Empty;
            }
            str += str.ToLower();
            StringBuilder sb = new StringBuilder(str);
            for (int i = 0; i < args.Length; i++)
            {
                if (args[i].Length == 1)
                {
                    sb.Replace(args[i].ToString(), string.Empty);
                }
                else
                {
                    int idxOfWord = sb.ToString().IndexOf(args[i]);
                    sb.Remove(idxOfWord, args[i].Length);
                }
            }
            return sb.ToString();
        }

        /// <summary>
        /// Checks if a given string contains any digits.
        /// </summary>
        /// <param name="str">The string to be used</param>
        /// <exception cref="ArgumentNullException">Thrown when the string is null</exception>
        /// <returns>True if the string contains any digits, false otherwise</returns>
        public static bool ContainsDigits(this string str)
        {
            if (str == null)
            {
                throw new ArgumentNullException();
            }
            if (str.Length == 0)
            {
                return false;
            }
            return str.Any(char.IsDigit);
        }

        /// <summary>
        /// Roughly mimics C style strings in that each character of the specified string is stored in a List
        /// </summary>
        /// <param name="str">The string to be used</param>
        /// <exception cref="ArgumentNullException">Thrown when the string is null</exception>
        /// <returns>The string represented as a List</returns>
        public static List<char> ToList(this string str)
        {
            if (str == null)
            {
                throw new ArgumentNullException();
            }
            if (str.Length == 0)
            {
                return new List<char>(0);
            }
            List<char> strcpy_list = new List<char>(str.Length);
            for(int i = 0; i < str.Length; i++) //For loop is faster than foreach in almost all scenarios
            {
                strcpy_list.Add(str[i]);
            }
            return strcpy_list;
        }

        /// <summary>
        /// Checks if a given string is a valid date used by System.DateTime
        /// </summary>
        /// <param name="str">The string to be used</param>
        /// <param name="format">The date format regex</param>
        /// <exception cref="ArgumentNullException">Thrown when the string is null</exception>
        /// <returns>True if the string is a valid date recognized by System.DateTime</returns>
        public static bool IsSystemDateTime(this string date, string formattingRegex)
        {
            if (date == null || formattingRegex == null)
            {
                throw new ArgumentNullException();
            }
            if (date.Length == 0 || formattingRegex.Length == 0)
            {
                return false;
            }
            return DateTime.TryParseExact(date, formattingRegex, CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime dt);
        }

        /// <summary>
        /// Checks if each character in a string is lexicographically greater than the previous character.
        /// </summary>
        /// <param name="str">The string to be used</param>
        /// <exception cref="ArgumentNullException">Thrown when the string is null</exception>
        /// <returns>True if the string strictly increases</returns>
        public static bool IsStrictlyIncreasing(this string str)
        {
            if (str == null)
            {
                throw new ArgumentNullException();
            }
            if (str.Length == 0)
            {
                return false;
            }
            for (int i = 0; i < str.Length - 1; i++)
            {
                if (str[i] > str[i + 1]) return false;
            }
            return true;
        }

        /// <summary>
        /// Checks if each character in a string is lexicographically greater than the previous character
        /// while ignoring case.
        /// </summary>
        /// <param name="str">The string to be used</param>
        /// <exception cref="ArgumentNullException">Thrown when the string is null</exception>
        /// <returns>True if the string strictly increases</returns>
        public static bool IsStrictlyIncreasingIgnoreCase(this string str)
        {
            if (str == null)
            {
                throw new ArgumentNullException();
            }
            if (str.Length == 0)
            {
                return false;
            }
            for (int i = 0; i < str.Length - 1; i++)
            {
                if (str[i] > str[i + 1]) return false;
            }
            return true;
        }

        /// <summary>
        /// Checks if each character in a string is lexicographically smaller than the previous character.
        /// 
        /// </summary>
        /// <param name="str">The string to be used</param>
        /// <exception cref="ArgumentNullException">Thrown when the string is null</exception>
        /// <returns>True if the string strictly increases</returns>
        public static bool IsStrictlyDecreasing(this string str)
        {
            if (str == null)
            {
                throw new ArgumentNullException();
            }
            if (str.Length == 0)
            {
                return false;
            }
            for (int i = 0; i < str.Length - 1; i++)
            {
                if (str[i] < str[i + 1]) return false;
            }
            return true;
        }

        /// <summary>
        /// Checks if each character in a string is lexicographically smaller than the previous character
        /// while ignoring case.
        /// </summary>
        /// <param name="str">The string to be used</param>
        /// <exception cref="ArgumentNullException">Thrown when the string is null</exception>
        /// <returns>True if the string strictly increases</returns>
        public static bool IsStrictlyDecreasingIgnoreCase(this string str)
        {
            if (str == null)
            {
                throw new ArgumentNullException();
            }
            if (str.Length == 0)
            {
                return false;
            }
            for (int i = 0; i < str.Length - 1; i++)
            {
                if (str[i] > str[i + 1]) return false;
            }
            return true;
        }

        /// <summary>
        /// Checks if a given string is a palindrome.
        /// </summary>
        /// <param name="str">The string to be used</param>
        /// <exception cref="ArgumentNullException">Thrown when the string is null</exception>
        /// <returns>True if the string is a palindrome</returns>
        public static bool IsPalindrome(this string str)
        {
            if (str == null)
            {
                throw new ArgumentNullException();
            }
            if (str.Length == 0)
            {
                return true; //empty string is a palindrome!
            }
            //All palindromes that exist are less than Int32.MaxValue
            for (int advancing = 0; advancing < str.Length; advancing++)
            {
                int retrograding = str.Length - 1 - advancing;
                if (str[advancing] != str[retrograding])
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Checks if a given string is a palindrome while ignoring casing
        /// </summary>
        /// <param name="str">The string to be used</param>
        /// <exception cref="ArgumentNullException">Thrown when the string is null</exception>
        /// <returns>True if the string is a palindrome</returns>
        public static bool IsPalindromeIgnoreCase(this string str)
        {
            if (str == null)
            {
                throw new ArgumentNullException();
            }
            if (str.Length == 0)
            {
                return true;
            }
            //All palindromes that exist are less than Int32.MaxValue
            str = str.ToLower();
            for (int advancing = 0; advancing < str.Length; advancing++)
            {
                int retrograding = str.Length - 1 - advancing;
                if (str[advancing] != str[retrograding])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
