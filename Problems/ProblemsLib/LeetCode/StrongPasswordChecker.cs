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
    /// 
    enum IssueType
    {
        Char, Repeat, Length 
    }

    enum ChangeType
    {
        Add, Remove, Replace
    }

    class Change
    {
        public ChangeType Type { get; set; }
        public IssueType Target { get; set; }
    }

    class RepeatedGroup: Change
    {
        public string Value { get; set; }
        public int Index { get; set; }
        public bool Fixed { get; set; }
        public bool SameWithPrev { get; set; }
    }

    public class StrongPasswordChecker
    {
        private int changes = 0;
        private Regex hasDigitRegex = new Regex("[0-9]");
        private Regex hasUpperCaseLetterRegex = new Regex("[A-Z]+");
        private Regex hasLowerCaseLetterRegex = new Regex("[a-z]+");
        private Regex hasRepeatsRegex = new Regex(@"(.)\1{2}");
        
        /*public int Check(string s)
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
                 changes++;
            }

            bool hasUpperCaseLetter = hasUpperCaseLetterRegex.IsMatch(s);
            if(!hasUpperCaseLetter)
            {
                 changes++;
            }

            bool hasLowerCaseLetter = hasLowerCaseLetterRegex.IsMatch(s);
            if(!hasLowerCaseLetter)
            {
                 changes++;
            }

            if(repeats >= changes)
            {
                repeats = repeats - changes;
            }
            else
            {
                changes = changes - repeats;
                repeats = 0;
            }

            if (s.Length > 20)
            {
                int overflow = (s.Length - 20);

                if (repeats >= overflow)
                {
                    return  changes + (repeats - overflow) + overflow;
                }
                else
                {
                    return changes + repeats + (overflow - repeats);
                }
            }

            if (s.Length < 6)
            {
                int add = 6 - s.Length;
                return add > changes ? add : changes;
            }

            changes += repeats;
            
            return changes;
        }*/


        public int Check(string input)
        {
            var changesList = new List<Change>();
            var repeats = new List<RepeatedGroup>();

            if (input == null)
            {
                throw new ArgumentNullException();
            }

            var matches = hasRepeatsRegex.Matches(input);
            RepeatedGroup prevGroup = null;
            foreach (var match in matches)
            {
                ChangeType fixType;
                var group = (Match)match;
                

                prevGroup = new RepeatedGroup
                {
                    Type = ChangeType.Replace,
                    Target = IssueType.Repeat,
                    SameWithPrev = prevGroup != null && prevGroup.Value == group.Value,
                    Value = group.Value,
                    Fixed = false,
                    Index = group.Index
                };

                repeats.Add(prevGroup); 
                changesList.Add(prevGroup);
            }

            bool hasDigit = hasDigitRegex.IsMatch(input);
            if (!hasDigit)
            {
                var repeatChange = repeats.FirstOrDefault(c => c.Target == IssueType.Repeat);
                if(repeatChange == null)
                {
                    changesList.Add(new Change
                    {
                        Target = IssueType.Char,
                        Type = ChangeType.Replace
                    });
                } else
                {
                    repeatChange.Target = IssueType.Char;
                }
                
            }

            bool hasUpperCaseLetter = hasUpperCaseLetterRegex.IsMatch(input);
            if (!hasUpperCaseLetter)
            {
                var repeatChange = repeats.FirstOrDefault(c => c.Target == IssueType.Repeat);
                if (repeatChange == null)
                {
                    changesList.Add(new Change
                    {
                        Target = IssueType.Char,
                        Type = ChangeType.Replace
                    });
                }
                else
                {
                    repeatChange.Target = IssueType.Char;
                }
            }

            bool hasLowerCaseLetter = hasLowerCaseLetterRegex.IsMatch(input);
            if (!hasLowerCaseLetter)
            {
                var repeatChange = repeats.FirstOrDefault(c => c.Target == IssueType.Repeat);
                if (repeatChange == null)
                {
                    changesList.Add(new Change
                    {
     
                        Target = IssueType.Char,
                        Type = ChangeType.Replace
                    });
                }
                else
                {
                    repeatChange.Target = IssueType.Char;
                }
            }

            if(input.Length < 6)
            {
                int add = 6 - input.Length;
                return add > changesList.Count ? add : changesList.Count;
            }

            if (input.Length > 20)
            {
                int groupCounter = 0;
                for (int i = 0; i < input.Length - 20; i++)
                {
                    var repeatChange = repeats.FirstOrDefault(c => c.Target == IssueType.Repeat);

                    if (repeatChange != null)
                    {
                        repeatChange.Target = IssueType.Length;
                        repeatChange.Type = ChangeType.Remove;

                        if (repeatChange.SameWithPrev && groupCounter == 0)
                        {
                            changesList.Add(new Change
                            {
                                Target = IssueType.Length,
                                Type = ChangeType.Replace
                            });
                        }
                    }
                    else
                    {
                        changesList.Add(new Change
                        {
                            Target = IssueType.Length,
                            Type = ChangeType.Remove
                        });
                    }
                }
            }

            return changesList.Count;
        }
    }
}
