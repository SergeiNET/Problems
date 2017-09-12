using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemsLib.LeetCode
{
    public class JudgeRouteCircle
    {
        public int X;
        public int Y;
        public bool JudgeCircle(string moves)
        {
            for(int i = 0; i < moves.Length; i++)
            {
                char move = moves[i];
                switch (move)
                {
                    case 'U':
                        {
                            Y++;
                            break;
                        }
                    case 'D':
                        {
                            Y--;
                            break;
                        }
                    case 'L':
                        {
                            X--;
                            break;
                        }
                    case 'R':
                        {
                            X++;
                            break;
                        }
                }
    

            }

            return X == 0 && Y == 0;
        }
    }
}
