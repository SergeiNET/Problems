using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemsLib.LeetCode
{
    public class BaseBall
    {
        static public int CalPoints(string[] ops)
        {
            int sum = 0;
            int score = 0;
            Stack<int> history = new Stack<int>(ops.Length);
            int prevScore1 = 0;
            int prevScore2 = 0;
            for (int i = 0; i < ops.Length; i++)
            {
                if (int.TryParse(ops[i], out score))
                {
                    history.Push(score);
                    prevScore2 = prevScore1;
                    prevScore1 = score;
                }
                else if (ops[i] == "+")
                {
                    score = prevScore2 + prevScore1;
                    prevScore2 = prevScore1;
                    prevScore1 = score;
                    history.Push(score);
                }
                else if (ops[i] == "D")
                {
                    score = prevScore1 * 2;
                    prevScore2 = prevScore1;
                    prevScore1 = score;
                    history.Push(score);
                }
                else if (ops[i] == "C")
                {
                    if (history.Count != 0)
                        history.Pop();
                    if (history.Count != 0)
                    {
                        prevScore1 = history.Pop();
                        if (history.Count != 0)
                        {
                            prevScore2 = history.Peek();
                        }
                        history.Push(prevScore1);
                    }
                }
            }

            return history.Sum();
        }
    }
}
