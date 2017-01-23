using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _344_Reverse_String
{
    /// <summary>
    /// Contains solutions to the Max Consecutive Ones problem.
    /// Due to ummutable nature of String in C# there is no way to reverse the string without allocating additional memory.
    /// </summary>
    public static class ReverseString_Solutions
    {
        /// <summary>
        /// StrightForwardWay to reverse string using temp String variable and reversed cycle.
        /// Not optimal in memory usage for long strings. Actually the worst solution in terms of memory and CPU utilization.
        /// </summary>
        /// <param name="s">String of any length</param>
        /// <returns>Reversed string</returns>
        public static string ReverseStringUsingTempString(string s)
        {
            string result = "";

            for (int i = s.Length-1; i >= 0; i--)
                result += s[i];

            return result;
        }

        /// <summary>
        /// StrightForwardWay to reverse string using temp StringBuilder variable and reversed cycle.
        /// </summary>
        /// <param name="s">String of any length</param>
        /// <returns>Reversed string</returns>
        public static string ReverseStringUsingStringBuilder(string s)
        {
            StringBuilder result = new StringBuilder("");

            for (int i = s.Length - 1; i >= 0; i--)
                result.Append(s[i]);

            return result.ToString();
        }

        /// <summary>
        /// Reverses string using reversing of chars array.
        /// Looks like this is the optimal option between other two.
        /// </summary>
        /// <param name="s">String of any length</param>
        /// <returns>Reversed string</returns>
        public static string ReverseStringUsingArrayOfChars(string s)
        {
            char[] charArray = s.ToCharArray();

            Array.Reverse(charArray);

            return new string(charArray);
        }
    }
}
