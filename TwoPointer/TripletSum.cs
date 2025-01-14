using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TwoPointer.TripletSum
{
    public static class Solution{
        public static IList<IList<int>> TripletSum(int[] nums){
            IList<IList<int>> ans = new List<IList<int>>();
            Array.Sort(nums);

            for (int i = 0; i < nums.Length - 2; i++) {
                if (i > 0 && nums[i] == nums[i - 1]){
                    continue;
                }
            
                int target = -nums[i];
                int left = i + 1, right = nums.Length - 1;

                while (left < right){

                    if (nums[left] + nums[right] == target){
                        ans.Add(new List<int> { nums[i], nums[left], nums[right]});
                        left++;
                        right--;

                        while (left < right && nums[left] == nums[left - 1]){
                            left++;
                        }
                    }else if (nums[left] + nums[right] < target){
                        left++;
                    }else {
                        right--;
                    }

                }
                
            }
            
            return ans;
        }
    }
}