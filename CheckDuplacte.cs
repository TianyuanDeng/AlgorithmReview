using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmReview
{
    class CheckDuplacte
    {
        public static bool CheckDuplactedChar(String s)
        {
            string afterTrim = s.Trim();
            HashSet<char> helper = new HashSet<char>();
            foreach (char c in s)
            {
                if (!helper.Add(c))
                {
                    return false; 
                }
            }
            return true;
        }
    }
}
