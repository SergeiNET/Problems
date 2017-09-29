using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemsLib.LeetCode
{
    public class MoveZeroesProblem
    {
        public void MoveZeroes(int[] nums)
        {
            for (int lastNonZeroIndex = 0, i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    var lastNonZeroElement = nums[lastNonZeroIndex];
                    nums[lastNonZeroIndex] = nums[i];
                    nums[i] = lastNonZeroElement;
                    lastNonZeroIndex++;
                }
            }
        }
    }

}
