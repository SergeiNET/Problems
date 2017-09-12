namespace ProblemsLib.LeetCode
{
    //https://leetcode.com/problems/reshape-the-matrix/description/
    public class MatrixReshapeProblem
    {
        public int[,] MatrixReshape(int[,] nums, int r, int c)
        {
            if(r * c != nums.Length)
            {
                return nums;
            }
            var enumerator = nums.GetEnumerator();
            var reshapedMatrix = new int[r, c];
            for(int i = 0; i < r; i++)
            {
                for(int j = 0; j < c; j++)
                {
                    if (enumerator.MoveNext())
                    {
                        reshapedMatrix[i, j] = (int)enumerator.Current;
                    }
                }
            }

            return reshapedMatrix;
        }
    }
}
