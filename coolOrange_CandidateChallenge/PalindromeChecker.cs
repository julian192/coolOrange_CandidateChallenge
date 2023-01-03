using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coolOrange_CandidateChallenge
{
    public class PalindromeChecker
    {
        public static bool IsPalindrome(string s)
        {
            int l = s.Length;
            for(int i = 0; i < l / 2; i++)
            {
                if (s[i] != s[l - i])
                    return false;
            }
            return true;
        }
    }
}
