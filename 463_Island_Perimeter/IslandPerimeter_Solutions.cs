using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _463_Island_Perimeter
{
    /// <summary>
    /// Contains solutions to the Island Perimeter problem
    /// </summary>
    public class IslandPerimeter_Solutions
    {
        /// <summary>
        /// My first solution based on simple looping through all 'land' positions and checking their neighbors.
        /// Works fine with 'two (and more) islands' input
        /// Alse works fine with 'inner lake' input
        /// </summary>
        /// <param name="grid">An Int32 array of ones and zeros with size less then 1000x1000. Where '1' is land and '0' is water</param>
        /// <returns>Perimeter of island</returns>
        public static int IslandPerimeterUsingCycleAndNeighborCheck(int[,] grid)
        {
            int result = 0;

            for (int i = 0; i < grid.GetLength(0); i++)
                for (int j = 0; j < grid.GetLength(1); j++)
                    if (grid[i, j] == 1)
                        result += GetShoreCount(grid, i, j);

            return result;
        }

        /// <summary>
        /// Checks 'land' position's neighbors to be water. 
        /// </summary>
        /// <returns>Number of 'shores' of one 'land' position</returns>
        private static int GetShoreCount(int[,] grid, int i, int j)
        {
            int shoreCount = 0;

            // check west neighbor
            if (j == 0 || (j > 0 && grid[i, j - 1] == 0))
                shoreCount++;
            // check north neighbor
            if (i == 0 || (i > 0 && grid[i - 1, j] == 0))
                shoreCount++;
            // check east neighbor
            if (j == grid.GetLength(1) - 1 || (j < grid.GetLength(1) - 1 && grid[i, j + 1] == 0))
                shoreCount++;
            // check south neighbor
            if (i == grid.GetLength(0) - 1 || (i < grid.GetLength(0) -1 && grid[i + 1, j] == 0))
                shoreCount++;

            return shoreCount;
        }
    }
}
