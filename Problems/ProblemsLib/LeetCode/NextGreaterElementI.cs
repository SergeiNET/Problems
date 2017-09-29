using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemsLib.LeetCode
{
    //https://leetcode.com/problems/next-greater-element-i/description/
    public class NextGreaterElementI
    {
        public int[] NextGreaterElement(int[] findNums, int[] nums)
        {
            if(findNums.Length == 0 || nums.Length == 0)
            {
                return new int[0];
            }
            var result = new int[findNums.Length];
            
            bool start = true;
            bool startSearch = false;
            int findNumsCursor = 0;
            int cursor = 0;
            while (start)
            {  
                if(nums[cursor] == findNums[findNumsCursor])
                {
                    startSearch = true;
                }

                cursor++;

                if (startSearch && cursor == nums.Length) {
                    result[findNumsCursor] = -1;
                    startSearch = false;
                    findNumsCursor++;
                    cursor = 0;
                }

                if (startSearch && nums[cursor] > findNums[findNumsCursor])
                {
                    result[findNumsCursor] = nums[cursor];
                    startSearch = false;
                    findNumsCursor++;
                    cursor = 0;
                }
                
                if(findNumsCursor == findNums.Length)
                {
                    break;
                }
            }

            return result;
        }

        /*public int SingleNumber(int[] nums)
        {
            return nums.GroupBy(n => n).Where(g => g.Count() == 1).Select(s => s);
        }*/
    }
}
