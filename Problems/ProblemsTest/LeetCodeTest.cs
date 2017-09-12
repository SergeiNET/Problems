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

        [TestMethod]
        public void HammingDistanceTest()
        {
           var res = HammingDistance.Run(1, 4);
        }

        [TestMethod]
        public void BT_Merge()
        {
            TreeNode t1 = new TreeNode(2);
            TreeNode t2 = new TreeNode(6);
            t1.left = new TreeNode(1);
            t1.right = new TreeNode(4);
            t1.right.right = new TreeNode(66);
            t2.left = new TreeNode(8);
            t2.right = new TreeNode(12);
            t1.left.left = new TreeNode(61);
            var res = MergeTwoBT.MergeTrees(t1, t2);
        }

        [TestMethod] 
        public void JudgeRouteCircle()
        {
            JudgeRouteCircle judge = new JudgeRouteCircle();
            var res = judge.JudgeCircle("LL");
        }

        [TestMethod]
        public void FindComplementTest()
        {
            FindComplementProblem probl = new FindComplementProblem();
            probl.FindComplement(5);
        }

        [TestMethod]
        public  void Reverse()
        {
            ReverseWords1 rev = new ReverseWords1();
            var res = rev.ReverseWords("Let's take LeetCode contest");
        }
    }
    
}
