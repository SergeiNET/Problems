using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemsLib.LeetCode
{
    public class ReverseWords1
    {
        public string ReverseWords(string s)
        {
            StringBuilder wordSb = new StringBuilder();
            var chars = s.ToCharArray();
            Stack<string> words = new Stack<string>();
            
            for(var i = chars.Length - 1; i >= 0; i--)
            {
                if (chars[i] != ' ')
                {
                    wordSb.Append(chars[i]);
                }

                if (chars[i] == ' ' || i == 0)
                {
                     words.Push(wordSb.ToString());
                     wordSb.Clear();
                }
            }

            return string.Join(" ", words);
        }
    }
}
