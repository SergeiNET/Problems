using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemsLib.LeetCode
{
    //575 https://leetcode.com/problems/distribute-candies/description/
    public class DistributeCandiesProblem
    {
        public int DistributeCandies(int[] candies)
        {
            HashSet<int> candieTypes = new HashSet<int>(candies);
            var partSize = candies.Length / 2;

            return candieTypes.Count > partSize ? partSize : candieTypes.Count;
        }
    }
}
