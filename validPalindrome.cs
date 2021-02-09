using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmReview
{
    class validPalindrome
    {
        public static Boolean IsPalindrome(String s)
        {
            if (s == null) return false;

            int left = 0;
            int right = s.Length - 1;

            while (left <= right)
            {
                var leftChar = s[left];
                var rightChar = s[right];

                if (char.IsLetterOrDigit(leftChar) && char.IsLetterOrDigit(rightChar))
                {
                    if (char.ToLower(leftChar) != char.ToLower(rightChar))
                    {
                        return false;
                    }

                    left++;
                    right--;

                }else if (char.IsLetterOrDigit(leftChar))
                {
                    right--;
                }else
                {
                    left++;
                }
            }

            return true;
        }
    }
}
