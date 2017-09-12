using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemsLib.LeetCode
{
    /*
     * public TreeNode TrimBST(TreeNode root, int L, int R) {
        // it is a binary search tree
        if (root == null) return root;
        
        if (root.val < L) return TrimBST(root.right, L, R);
        if (root.val > R) return TrimBST(root.left, L, R);
        
        root.left = TrimBST(root.left, L, R);
        root.right = TrimBST(root.right, L, R);
        
        return root;
        
    }
     */
    public class TrimBSTProblem
    {
        // From site
        public TreeNode TrimBST(TreeNode root, int L, int R)
        {
            // it is a binary search tree
            if (root == null) return root;

            if (root.val < L) return TrimBST(root.right, L, R);
            if (root.val > R) return TrimBST(root.left, L, R);

            root.left = TrimBST(root.left, L, R);
            root.right = TrimBST(root.right, L, R);

            return root;

        }

        //My solution
        TreeNode trimmedBST;
        int L;
        int R;
        public TreeNode TrimBST_(TreeNode root, int L, int R)
        {
            this.L = L;
            this.R = R;
            EnumerateBST(root);
            return trimmedBST;
        }

        public void AddToTrimmed(int val)
        {
            if (trimmedBST == null)
            {
                trimmedBST = new TreeNode(val);
            }
            else
            {
                AddNode(trimmedBST, val);
            }
        }

        void EnumerateBST(TreeNode node)
        {
            if (node == null)
            {
                return;
            }

            if (node.val >= L && node.val <= R)
            {
                AddToTrimmed(node.val);
            }

            EnumerateBST(node.left);
            EnumerateBST(node.right);
        }

        public void AddNode(TreeNode root, int value)
        {
            if (value < root.val)
            {
                if (root.left == null)
                {
                    root.left = new TreeNode(value);
                }
                else
                {
                    AddNode(root.left, value);
                }
            }
            else if (value > root.val)
            {
                if (root.right == null)
                {
                    root.right = new TreeNode(value);
                }
                else
                {
                    AddNode(root.right, value);
                }
            }
        }
    }
}
