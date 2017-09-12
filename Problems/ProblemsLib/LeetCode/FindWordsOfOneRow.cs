using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemsLib.LeetCode
{
    /// <summary>
    /// Given a List of words, return the words that can be typed using letters of alphabet on only one row's of American keyboard like the image below.
    /// </summary>
    class FindWordsOfOneRow
    {
        HashSet<char> row1 = new HashSet<char> { 'q', 'w', 'e', 'r', 't', 'y', 'u', 'i', 'o', 'p' };
        HashSet<char> row2 = new HashSet<char> { 'a', 's', 'd', 'f', 'g', 'h', 'j', 'k', 'l' };
        HashSet<char> row3 = new HashSet<char> { 'z', 'x', 'c', 'v', 'b', 'n', 'm'};
        public string[] FindWords(string[] words)
        {
            return words.Where(w =>
            {
                var chars = w.ToLower().ToCharArray().Distinct();
                return row1.IsSupersetOf(chars) || row2.IsSupersetOf(chars) || row3.IsSupersetOf(chars);
            }).ToArray(); 
        }
    }
}
