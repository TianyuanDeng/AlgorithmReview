using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlgorithmReview
{
    class quickSort
    {
        public static int[] QuickSort(int[] array)
        {
            recursion(array, 0, array.Length - 1);
            return array;
        }
        public static void recursion(int[] array, int left, int right)
        {
            if (left >= right)
            {
                return;
            }

            int mid = left + (right - left) / 2;
            swap(array, mid, right);

            int i = left;
            int j = right - 1;

            while (i <= j)
            {
                if (array[i] < array[right])
                {
                    i++;
                }
                else
                {
                    swap(array, i, j);
                    j--;
                }
            }

            swap(array, i, right);

            recursion(array, left, i - 1);
            recursion(array, i + 1, right);
        }
        public static void swap(int[] array, int left, int right)
        {
            int temp = array[left];
            array[left] = array[right];
            array[right] = temp;
        }

        public int NumDistinct(string s, string t)
        {
            int M = s.Length;
            int N = t.Length;

            int[,] dp = new int[M + 1, N + 1];

            // Base case initialization
            for (int j = 0; j <= N; j++)
            {
                dp[M, j] = 0;
            }

            // Base case initialization
            for (int i = 0; i <= M; i++)
            {
                dp[i, N] = 1;
            }

            // Iterate over the strings in reverse so as to
            // satisfy the way we've modeled our recursive solution
            for (int i = M - 1; i >= 0; i--)
            {
                for (int j = N - 1; j >= 0; j--)
                {

                    // Remember, we always need this result
                    dp[i, j] = dp[i + 1, j];

                    // If the characters match, we add the
                    // result of the next recursion call (in this
                    // case, the value of a cell in the dp table
                    if (s[i] == t[j])
                    {
                        dp[i, j] += dp[i + 1, j + 1];
                    }
                }
            }

            return dp[0, 0];
        }

        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                dic.Add(nums[i], i);
                if (dic.ContainsKey(target - nums[i]))
                {
                    return new int[] { dic[target - nums[i]], i };
                }
            }

            return new int[] { };
        }
    }
}
