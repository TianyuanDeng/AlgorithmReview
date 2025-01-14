using System;
using System.Collections.Generic;

namespace HashSet.PairSum
{
    public class Solution{
        public static int[] PairSumUnSorted(int[] nums, int target) {
            Dictionary<int, int> set = new Dictionary<int, int>(); 

            for (int i = 0; i < nums.Length - 1; i++) {
                if (set.ContainsKey(target - nums[i])){
                    return new int[] {set[target - nums[i]], i};
                }

                set.Add(nums[i], i);
            }

            return Array.Empty<int>();
        }
    }
}