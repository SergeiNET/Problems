using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemsLib.LeetCode
{
    public class AverageOfLevelsInBinaryTree
    {
        Dictionary<int, List<long>> levelsAvg = new Dictionary<int, List<long>>();
        public IList<double> AverageOfLevels(TreeNode root)
        {
            Traverse(root, 0);
            List<double> result = new List<double>(levelsAvg.Keys.Count);
            foreach(var level in levelsAvg.Keys)
            {
                result.Add(levelsAvg[level].Sum() / (double)levelsAvg[level].Count);
            }

            return result;
        }

        public void Traverse(TreeNode node, int level)
        {
            if(node == null)
            {
                return;
            }

            if(levelsAvg.ContainsKey(level))
            {
                levelsAvg[level].Add(node.val);
            }
            else
            {
                levelsAvg.Add(level, new List<long> { node.val });
            }
            Traverse(node.left, level + 1);
            Traverse(node.right, level + 1);
        }
    }
}
