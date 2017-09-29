using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemsLib.LeetCode
{
    //https://leetcode.com/problems/find-the-difference/description/
    public class StringDiff
    {
        public char FindTheDifferenceDict(string s, string t)
        {
            var charArrS = s.ToCharArray();
            var map = new Dictionary<char, int>();
            foreach (var letter in charArrS)
            {
                if (map.ContainsKey(letter))
                {
                    map[letter] = map[letter] + 1;
                }
                else
                {
                    map.Add(letter, 1);
                }
            }

            var charArrT = t.ToCharArray();
            foreach (var letter in charArrT)
            {
                if (!map.ContainsKey(letter))
                {
                    return letter;
                }
                else
                {
                    map[letter] = map[letter] - 1;
                    if (map[letter] == -1)
                    {
                        return letter;
                    }
                }
            }

            return default(char);
        }

        //Summ
        public char FindTheDifference(string s, string t)
        {
            HashSet<int> valueSet = new HashSet<int>();
              //  valueSet.
            var sSum = s.ToCharArray().Sum(c => c);
            var tSum = t.ToCharArray().Sum(c => c);
            var diff = tSum - sSum;
            return (char)diff;
        }
    }
}
