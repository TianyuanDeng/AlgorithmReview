using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmReview
{
    class FirstMissingNumber
    {
        public static int firstMissingPositive(int[] nums)
        {
            int n = nums.Length;

            for (int i = 0; i < n; i++)
            {
                if (nums[i] <= 0 )
                {
                    nums[i] = n + 1;
                }
            }
            Array.ForEach(nums, Console.WriteLine);

            for (int i = 0; i < n; i++)
            {
                int a = Math.Abs(nums[i]);
                //int a = nums[i];
                if (a <= n)
                {
                    nums[a - 1] = -Math.Abs(nums[a - 1]);
                }
            }
            Console.WriteLine("after:");
            Array.ForEach(nums, Console.WriteLine);

            for (int i = 0; i < n; i++)
            {
                if (nums[i] > 0)
                {
                    return i + 1;
                }
            }

            return n + 1;
        }
    }
}
