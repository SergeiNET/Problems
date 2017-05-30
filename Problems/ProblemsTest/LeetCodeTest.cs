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
    }
}
