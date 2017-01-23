using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _463_Island_Perimeter
{
    // TODO Needs description
    public class IslandPerimeter_Solutions
    {
        // TODO Needs description
        public static int IslandPerimeterUsingCycleAndNeighborCheck(int[,] grid)
        {
            int result = 0;

            for (int i = 0; i < grid.GetLength(0); i++)
                for (int j = 0; j < grid.GetLength(1); j++)
                    if (grid[i, j] == 1)
                        result += GetShoreCount(grid, i, j);

            return result;
        }

        // TODO Write a comment
        /// <summary>
        /// 
        /// </summary>
        private static int GetShoreCount(int[,] grid, int i, int j)
        {
            int shoreCount = 0;

            // check left neighbor
            if (j == 0 || (j > 0 && grid[i, j - 1] == 0))
                shoreCount++;
            // check top neighbor
            if (i == 0 || (i > 0 && grid[i - 1, j] == 0))
                shoreCount++;
            // check right neighbor
            if (j == grid.GetLength(1) - 1 || (j < grid.GetLength(1) - 1 && grid[i, j + 1] == 0))
                shoreCount++;
            // check bottom neighbor
            if (i == grid.GetLength(0) - 1 || (i < grid.GetLength(0) -1 && grid[i + 1, j] == 0))
                shoreCount++;

            return shoreCount;
        }
    }
}
