using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemsLib.LeetCode
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }

    public class MergeTwoBT
    {
        //static TreeNode mergedTree;
        public static TreeNode MergeTrees(TreeNode t1, TreeNode t2)
        {
            TreeNode mergedTree = null;
            CLR(t1, t2, ref mergedTree);
            return mergedTree;
        }

        private static void CLR(TreeNode t1, TreeNode t2, ref TreeNode mergedTree)
        {
            if(t1 == null && t2 == null)
            {
                return;
            }
            if(t1 != null)
                if(mergedTree == null)
                {
                    mergedTree = new TreeNode(t1.val);
                } else
                {
                    mergedTree.val += t1.val;
                }
            if (t2 != null)
                if (mergedTree == null)
                {
                    mergedTree = new TreeNode(t2.val);
                }
                else
                {
                    mergedTree.val += t2.val;
                }

                CLR(t1?.left, t2?.left, ref mergedTree.left);

                CLR(t1?.right, t2?.right, ref mergedTree.right);
        }
        /*
        public TreeNode MergeTrees(TreeNode t1, TreeNode t2)
        {
            if (t1 == null) return t2;
            if (t2 == null) return t1;

            t1.left = MergeTrees(t1.left, t2.left);
            t1.right = MergeTrees(t1.right, t2.right);
            t1.val += t2.val;
            return t1;
        }*/
    }
}
