using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemsLib.CrackingInterview
{
    public class Solutions
    {
        /*
         * Is Unique: Implement an algorithm to determine if a 
         * string has all unique characters. What if you
         * cannot use additional data structures?
         * page 192
         */

        public static bool IsUniqueChars(string str)
        {
            if (str.Length > 128) return false;
            bool[] char_set = new bool[128];

            for (int i = 0; i < str.Length; i++)
            {
                int val = str[i];
                if (char_set[val])
                {
                    // Already found this char in string
                    return false;
                }

                char_set[val] = true;
            }

            return true;
        }

        //Bit operations
        public static bool IsUniqueChars1(string str)
        {
            long checker = 0;
            for (int i = 0; i < str.Length; i++)
            {
                int val = str[i];
                if ((checker & (1 << val)) > 0)
                {
                    // Already found this char in string
                    return false;
                }

                checker |= (1 << val);
            }

            return true;
        }

        //Check Permutation: Given two strings, write a method to decide if one is a permutation of the
        //other.
        //Slow
        public bool Permutation(string s, string t)
        {
            if (s.Length != t.Length) return false;

            return new string(s.OrderBy(i => i).ToArray()) == new string(s.OrderBy(i => i).ToArray());
        }

        //Fast
        public bool Permutation1(string s, string t)
        {
            if (s.Length != t.Length) return false;

            int[] letters = new int[128]; // Assumption
            //char[] s_array = s.ToCharArray();
            foreach (char c in s)
            {
                // count number of each char i n s.
                letters[c]++;
            }
            for (int i = 0; i < t.Length; i++)
            {
                int c = t[i];
                letters[c]--;

                if (letters[c] < 0)
                {
                    return false;
                }
            }

            return true;
        }

        /*
          URLify: Write a method to replace all spaces in a string with '%2e: You may assume that the string
          has sufficient space at the end to hold the additional characters, and that you are given the "true"
          length of the string. (Note: if implementing in Java, please use a character array so that you can
          perform this operation in place.)
          EXAMPLE
          Input: "Mr John Smith JJ, 13
          Output: "Mr%2eJohn%2eSmith"
        */

        void ReplaceSpaces(char[] str, int trueLength)
        {
            int spaceCount = 0, index, i = 0;
            for (i = 0; i < trueLength; i++)
            {
                if (str[i] == ' ')
                {
                    spaceCount++;
                }
            }


            index = trueLength + spaceCount * 2;
            if (trueLength < str.Length)
                str[trueLength] = '\0';// End array

            for (i = trueLength - 1; i >= 0; i--)
            {
                if (str[i] == ' ')
                {
                    str[index - 1] = '0';
                    str[index - 2] = '2';
                    str[index - 3] = '%';
                    index = index - 3;

                }
                else
                {
                    str[index - 1] = str[i];
                    index--;
                }
            }
        }

/*
Palindrome Permutation: Given a string, write a function to check if it is a permutation of
a palindrome. A palindrome is a word or phrase that is the same forwards and backwards. A
permutation is a rearrangement of letters. The palindrome does not need to be limited to just
dictionary words.
EXAMPLE
Input: Tact Coa
Output: True (permutations:"taco cat'; "atco cta'; etc.)
*/


    }
}
