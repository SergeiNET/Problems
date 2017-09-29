using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemsLib.LeetCode
{
    public class FirstUniqueChar
    {
        //Fast
        static public int FirstUniqChar(string s)
        {
            var memo = new int[26];
            var maxInd = s.Length;
            int minInd = maxInd;

            for (int i = 0; i < s.Length; i++)
            {
                memo[s[i] - 'a']++;
            }

            for (int i = 0; i < s.Length; i++)
            {
                if (memo[s[i] - 'a'] == 1) return i;
            }

            return -1;
        }
    }
}

