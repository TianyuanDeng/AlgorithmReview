using System;

namespace TwoPointer.PairSum
{
    public class Solution {
        public static int[] PairSum(int[] nums, int target){
            int left = 0;
            int right = nums.Length - 1;

            while(left < right){
                    if (nums[left] + nums[right] == target){
                        return new int[] {left, right};
                    }else if (nums[left] + nums[right] < target){
                        left++;
                    }else {
                        right--;
                    }
            }

            return Array.Empty<int>();
        }
        
    }
}