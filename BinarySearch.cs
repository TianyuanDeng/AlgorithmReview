using System;

namespace AlgorithmReview
{
    class BinarySearch
    {
        //O(logn)
        public static int binarySearch(int[] nums, int low, int high, int target)
        {
            if (high <= low) return -1;

            //low + high/2 - low/2 => 2low + high - low 
            int mid = low + (high - low) / 2;

            if (nums[mid] > target)
            {
                return binarySearch(nums, low, mid, target);
            }else if (nums[mid] < target)
            {
                return binarySearch(nums, mid + 1, high, target);
            }else
            {
                return nums[mid];
            }
        }
    }
}
