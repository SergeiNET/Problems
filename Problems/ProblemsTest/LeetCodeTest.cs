using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProblemsLib.LeetCode;

namespace ProblemsTest
{
    [TestClass]
    public class LeetCodeTest
    {
        [TestMethod]
        public void MedianOfTwoArraysProblemTest()
        {
            MedianOfTwoSortedArrays problem = new MedianOfTwoSortedArrays();
            var res = problem.FindMedianSortedArrays(new int[0], new[] { 1000 });
        }

        [TestMethod]
        public void StrongPasswordTest()
        {
            StrongPasswordChecker problem = new StrongPasswordChecker();
            var res = problem.Check("aaaaaaaaaaaaaaaaaaaaa");
        }
        //aaa123


    }
}
