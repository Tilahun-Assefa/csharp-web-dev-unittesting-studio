using System;

namespace BalancedBracketsNS
{
    public class BalancedBrackets
    {
        /**
         * The function BalancedBrackets should return true if and only if
         * the input string has a set of "balanced" brackets.
         *
         * That is, whether it consists entirely of pairs of opening/closing
         * brackets (in that order), none of which mis-nest. We consider a bracket
         * to be square-brackets: [ or ].
         *
         * The string may contain non-bracket characters as well.
         *
         * These strings have balanced brackets:
         *  "[LaunchCode]", "Launch[Code]", "[]LaunchCode", "", "[]"
         *
         * While these do not:
         *   "[LaunchCode", "Launch]Code[", "[", "]["
         *
         * parameter str - to be validated
         * returns true if balanced, false otherwise
        */
        public static bool HasBalancedBrackets(String str)
        {            
            int brackets = 0;
            if(str == null)
            {
                return false;
            }

            if(str.Length == 0)
            {
                return true;
            }
            else
            {
                foreach (char ch in str.ToCharArray())
                {
                    if (ch == '[')
                    {
                        brackets++;
                    }
                    else if (ch == ']')
                    {
                        if(brackets == 0)
                        {
                            return false;
                        }
                        else
                        {
                            brackets--;
                        }                        
                    }
                }
                return brackets == 0;
            }            
        }

        static int i = 0;
        static int j = -1;
        static int count = 0;
        static string s = "test[[bracket]][](parhent)";
        public static bool IsBalancedBracket()
        {

            if (s.Length == 0)
            {
                return true;
            }
            else
            {
                int result;
                while (i < s.Length)
                {
                    char temp = s[i];
                    if (temp == ']')
                    {
                        result = HelperFunc('[');
                        if (result == 0)
                        {
                            return false;
                        }
                    }
                    else
                    {
                        j = i;
                        i++;
                        count++;
                    }
                }
                if (count != 0)
                {
                    return false;
                }
                return true;
            }
        }

        public static int HelperFunc(char brk)
        {
            count--;
            char temp = s[j];

            if (j > -1 && temp == brk)
            {
                s = s.Replace(s[i], '#');
                s = s.Replace(s[j], '#');

                temp = s[j];
                while (j >= 0 && temp == '#')
                    j--;

                i++;
                return 1;
            }
            else
                return 0;
        }
    }
}
