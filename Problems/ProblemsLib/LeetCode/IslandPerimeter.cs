using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemsLib.LeetCode
{
    public class IslandPerimeterProblem
    {
        //https://leetcode.com/problems/island-perimeter/description/
        public int IslandPerimeter(int[,] grid)
        {
            int perimeter = 0;
            for(int i = 0; i < grid.GetLength(0); i++)
            {
                for (int j = 0; j < grid.GetLength(1); j++)
                {
                    if(grid[i,j] == 1)
                    {
                        int freeSides = 4;
                        if (i != 0 && grid[i - 1, j] == 1)
                        {
                            freeSides--;
                        }

                        if (i != grid.GetLength(0) - 1 && grid[i + 1, j] == 1)
                        {
                            freeSides--;
                        }

                        if (j != 0 && grid[i, j - 1] == 1)
                        {
                            freeSides--;
                        }

                        if (j != grid.GetLength(1) - 1 && grid[i, j + 1] == 1)
                        {
                            freeSides--;
                        }

                        perimeter += freeSides;
                    }
                }
            }
            return perimeter;
        }

        // slows solution
        public int FreeSidesCount(int[,] grid, int i, int j)
        {
            int freeSides = 4;
            if(i != 0 && grid[i - 1,j] == 1)
            {
                freeSides--;
            }

            if (i != grid.GetLength(0) - 1 && grid[i + 1, j] == 1)
            {
                freeSides--;
            }

            if (j != 0 && grid[i, j - 1] == 1)
            {
                freeSides--;
            }

            if (j != grid.GetLength(1) - 1 && grid[i, j + 1] == 1)
            {
                freeSides--;
            }

            return freeSides;
        }
    }
}
