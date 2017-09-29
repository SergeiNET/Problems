using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemsLib.CrackingInterview
{
    // 0 1 1 2 3 5 8 13
    public class FibNum
    {
        public static int Fibonacci(int n)
        {
            return Fibonacci(n, new int[n + 1]);
        }

        public static int Fibonacci(int i, int[] memo)
        {
            if(i == 0 || i == 1)
            {
                return i;
            }

            if(memo[i] == 0)
            {
                memo[i] = Fibonacci(i - 1, memo) + Fibonacci(i - 2, memo);
            } 

            return memo[i];
        }

        public static int FibonacciIterative(int n)
        {
            if (n == 0)
            {
                return 0; ;
            }

            int a = 0;
            int b = 1;
            for(int i = 2; i < n; i++)
            {
                int c = a + b;
                a = b;
                b = c;
            }

            return a + b;
        }


    }
}
