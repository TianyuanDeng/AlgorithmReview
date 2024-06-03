using System;

namespace MergeSortedArray 
{
    public class Solution {
        public void Merge(int[] nums1, int m, int[] nums2, int n) {
            if (m == 0 && n == 0){
                return;
            } else if(m != 0 && n == 0){
                return;
            } else if (m == 0 && n != 0){
                for (int i = 0; i < n; i++) {
                    nums1[i] = nums2[i];
                }
                return;
            } else {
                int pointer1 = 0;
                int pointer2 = 0;
                int[] result = new int[m + n];
                int index = 0;

                while (pointer1 < m && pointer2 < n) {
                    if (nums1[pointer1] <= nums2[pointer2]) {
                        result[index++] = nums1[pointer1++];
                    } else {
                        result[index++] = nums2[pointer2++];
                    }
                }

                while (pointer1 < m) {
                    result[index++] = nums1[pointer1++];
                }

                while (pointer2 < n) {
                    result[index++] = nums2[pointer2++];
                }

                for (int i = 0; i < m + n; i++) {
                    nums1[i] = result[i];
                }
            }
        }
    }
}
