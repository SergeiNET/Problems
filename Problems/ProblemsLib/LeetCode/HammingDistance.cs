using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemsLib.LeetCode
{
    public class HammingDistance
    {
        public static int Run(int x, int y)
        {
            int hammingDistance = 0;
            for(int i=0; i < 32; i++)
            {
                if(GetBit(x, i) != GetBit(y, i))
                {
                    hammingDistance++;
                }
            }

            return hammingDistance;
        }

        public static int GetBit(int val, int position)
        {
            return (val >> position) & 1;
        }
    }
}
