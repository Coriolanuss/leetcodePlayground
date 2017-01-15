using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _485_Max_Consecutive_Ones
{
    /// <summary>
    /// Contains Solutions to the Max Consecutive Ones problem
    /// </summary>
    public class MaxConsecutiveOnes_Solutions
    {
        /// <summary>
        /// My simple solution to Max Consecutive Ones problem
        /// </summary>
        /// <param name="nums">An array with the length of 1 to 10,000 containing only '0's and '1's</param>
        /// <returns>The length of the longest sequence of ones</returns>
        public int FindMaxConsecutiveOnes_Mine(int[] nums)
        {
            int counter = 0;
            int maxCounter = 0;

            foreach(int x in nums)
            {
                if (x == 1)
                    counter++;
                else
                {
                    if (maxCounter < counter) maxCounter = counter;
                    counter = 0;
                }
            }

            if (maxCounter < counter) maxCounter = counter;
            return maxCounter;
        }       
    }
}
