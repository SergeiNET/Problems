using ProblemsLib.CrackingInterview;
using ProblemsLib.LeetCode;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Problems
{


    class Program
    {
        static public void SingleNumber()
        {
            //var res = nums.GroupBy(n => n).Where(g => g.Count() == 1).Select(s => s.Key).First();
            // single ^= each element
        }

        static void Main(string[] args)
        {
            var r1 = Solutions.IsUniqueChars("FARETRYEW");
            var r2 = Solutions.IsUniqueChars1("124356987");


            var r = FibNum.Fibonacci(25);
            Stack<int> s = new Stack<int>();
            s.Clear();

            var arr = new int[0];
            AddTwoNumbersProblem prob1 = new AddTwoNumbersProblem();
            var res = prob1.Solve();

            Dictionary<char, int> dd = new Dictionary<char, int>();
         
            
            var res1 = LongestSubstringWithoutRepeatingCharacters.LengthOfLongestSubstring("dvdf");

            ProblemsLib.LinkedListWith.LinkedList<string> testList = new ProblemsLib.LinkedListWith.LinkedList<string>();
            testList.Add("First");
            testList.Add("Second");
            testList.Add("Third");
            testList.Add("Fourth");
            testList.Add("Fifth");
            char u = '6';

            testList.Remove("Third");


            var el1 = testList.GetNFromTheEnd(1);
            var el = testList.GetNFromTheEnd(0);
            foreach (var val in testList)
            {
                Console.WriteLine(val);
            }

            Console.ReadKey();
        }
    }
}
