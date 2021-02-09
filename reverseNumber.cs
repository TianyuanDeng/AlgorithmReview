using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmReview
{
    class reverseNumber
    {
        public static int ReverseNumber(int num)
        {
            int ans = 0;

            while (num != 0)
            {
                int temp = num % 10;
                num = num / 10;

                if (ans > int.MaxValue / 10) return 0;
                else if (ans < int.MinValue / 10) return 0;

                ans = ans * 10 + temp;
            }

            return ans; 
        }
    }
}
