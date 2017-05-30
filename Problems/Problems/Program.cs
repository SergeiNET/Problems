using ProblemsLib.LeetCode;
using System;


namespace Problems
{


    class Program
    {
        static void Main(string[] args)
        {
            AddTwoNumbersProblem prob1 = new AddTwoNumbersProblem();
            var res = prob1.Solve();


            //"pwwkew"
            var res1 = LongestSubstringWithoutRepeatingCharacters.LengthOfLongestSubstring("dvdf");

            ProblemsLib.LinkedListWith.LinkedList<string> testList = new ProblemsLib.LinkedListWith.LinkedList<string>();
            testList.Add("First");
            testList.Add("Second");
            testList.Add("Third");
            testList.Add("Fourth");
            testList.Add("Fifth");

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
