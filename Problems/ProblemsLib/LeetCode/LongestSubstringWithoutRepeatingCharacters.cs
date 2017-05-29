using System.Collections.Generic;


namespace ProblemsLib.LeetCode
{
    public class LongestSubstringWithoutRepeatingCharacters 
    {
        public static int LengthOfLongestSubstring(string s)
        {
            int maxLength = 0;
            int length = 0;
            int passage = 0;
            HashSet<char> chars = new HashSet<char>();
            for(var i = 0; i < s.Length; i++)
            {
                if(chars.Add(s[i]))
                {
                    length++;
                }
                else
                {
                    maxLength = length > maxLength ? length : maxLength;

                    chars.Clear();
                    length = 0;

                    i = passage;
                    passage++;
                }
            }

            return length > maxLength ? length : maxLength;
        }
    }
}
