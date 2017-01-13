using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _412_Fizz_Buzz
{
    /// <summary>
    /// Contains solutions to "Fizz Buzz" problem
    /// </summary>
    public class FizzBuzz_Solutions
    {
        /// <summary>
        /// Iterates through numbers and returns list of words
        /// </summary>
        /// <param name="n">Number of words in output list</param>
        /// <returns>List of words, which correspond to the rules:
        /// if number % 3 == 0 => "Fizz"
        /// if number % 3 == 0 => "Buzz"
        /// if number % 15 == 0 => "FizzBuzz"
        /// else => number</returns>
        public static IList<string> FizzBuzz(int n)
        {
            List<string> result = new List<string>();
            for (int i = 1; i <= n; i++)
            {
                result.Add(SelectRespond(i));
            }
            return result;
        }

        /// <summary>
        /// Returns string according to the rules of the task
        /// </summary>
        /// <param name="numb">[0; Int.MaxValue]</param>
        /// <returns>"Fizz"/"Buzz"/"FizzBuzz"</returns>
        public static string SelectRespond(int numb)
        {
            if (numb % 3 == 0 && numb % 5 == 0)
                return "FizzBuzz";
            else if (numb % 3 == 0)
                return "Fizz";
            else if (numb % 5 == 0)
                return "Buzz";
            else
                return numb.ToString();
        }
    }
}
