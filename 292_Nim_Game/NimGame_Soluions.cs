using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _292_Nim_Game
{
    /// <summary>
    /// Solutions to a Nim Game problem, where you and your opponent are given a heap of stones and both of you can take 1, 2 or 3 stones from the heap in turns. The one who takes the last stone wins.
    /// The problem is to culculate if you can win at all in case of given number of stones "n" in the heap and it's your turn.
    /// </summary>
    public class NimGame_Soluions
    {
        /// <summary>
        /// My first try to solve the problem without looking into any hints or references.
        /// </summary>
        /// <note>It turned out that this solution is best in terms math.</note>
        /// <param name="n">Number of stones in the heap. Must be &gt; 0 and &lt; Int32.MaxValue</param>
        /// <returns>"True" if you can win and "false" if you can't at the given conditions</returns>
        public static bool CanWinNimMyFirstSolution(int n)
        {
            if (n <= 0)
                throw new ArgumentOutOfRangeException("n", n, "Number of stones in the heap. Must be > 0 and < Int32.MaxValue");
            if (n % 4 == 0)
                return false;
            else
                return true;
        }
    }
    // TODO Add Unit-tests
}
