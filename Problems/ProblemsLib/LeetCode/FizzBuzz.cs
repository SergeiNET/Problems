using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemsLib.LeetCode
{
    public class FizzBuzzProblem
    {
        //https://leetcode.com/problems/fizz-buzz/description/
        public IList<string> FizzBuzz(int n)
        {
            IList<string> result = new List<string>(n);
            for(int i = 1; i <= n; i++)
            {
                if(i % 3 == 0 && i % 5 == 0)
                {
                    result.Add("FizzBuzz");
                }
                else if(i % 3 == 0)
                {
                    result.Add("Fizz");
                } 
                else if (i % 5 == 0)
                {
                    result.Add("Buzz");
                }
                else
                {
                    result.Add(i.ToString());
                }               
            }
            return result;
        }
    }
}
