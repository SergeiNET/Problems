using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ProblemsLib.LeetCode
{
    /// <summary>
    /// A password is considered strong if below conditions are all met:
    //    It has at least 6 characters and at most 20 characters.
    //    It must contain at least one lowercase letter, at least one uppercase letter, and at least one digit.
    //    It must NOT contain three repeating characters in a row ("...aaa..." is weak, but "...aa...a..." is strong, assuming other conditions are met).
    //Write a function strongPasswordChecker(s), that takes a string s as input, and return the MINIMUM change required to make s a strong password.If s is already strong, return 0.
    //Insertion, deletion or replace of any one character are all considered as one change.
    /// </summary>
    public class StrongPasswordChecker
    {
        private int changes = 0;
        private Regex hasDigitRegex = new Regex("[0-9]");
        private Regex hasUpperCaseLetterRegex = new Regex("[A-Z]+");
        private Regex hasLowerCaseLetterRegex = new Regex("[a-z]+");
        private Regex hasRepeatsRegex = new Regex(@"(.)\1{2}");
        
        public int Check(string s)
        {
            if (s == null)
            {
                throw new ArgumentNullException();
            }
            
            var matches = hasRepeatsRegex.Matches(s);
            int repeats = matches.Count;
            int intersectionFixes = matches.Count > 3 ? 3 : matches.Count;

            bool hasDigit = hasDigitRegex.IsMatch(s);
            if(!hasDigit)
            {
                intersectionFixes--;
                if (intersectionFixes <= 0)
                {
                    changes++;
                    if (repeats > 0) repeats--;
                }
            }

            bool hasUpperCaseLetter = hasUpperCaseLetterRegex.IsMatch(s);
            if(!hasUpperCaseLetter)
            {
                intersectionFixes--;
                if (intersectionFixes <= 0)
                {
                    changes++;
                    if (repeats > 0) repeats--;
                }
            }

            bool hasLowerCaseLetter = hasLowerCaseLetterRegex.IsMatch(s);
            if(!hasLowerCaseLetter)
            {
                intersectionFixes--;
                if (intersectionFixes <= 0)
                {
                    changes++;
                    if(repeats > 0) repeats--;
                }
            }

            changes += repeats;
            if (s.Length < 6)
            {
                int add = 6 - s.Length;
                return add > changes ? add : changes;
            }

            if (s.Length > 20)
            {
                int remove = (s.Length - 20);
                changes -= repeats;
                if (remove < repeats)
                {
                    changes += repeats - remove;
                } 

                return remove + changes;
            }

            return changes;
        }
    }
}
