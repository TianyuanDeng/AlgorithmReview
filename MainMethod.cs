using System;
using System.Collections.Generic;
using System.Text;
using MergeSortedArray;

namespace AlgorithmReview
{
    class MainMethod
    {
        public static void Main()
        {
            // String s = "aaAbcd,!";
            // if (CheckDuplacte.CheckDuplactedChar(s))
            // {
            //     Console.WriteLine("No, it does not have duplacted char");
            // }else
            // {
            //     Console.WriteLine("Yes, it has duplacted char");
            // }

            //88-MergeSortedArray
            int[] nums1 = new int[6] { 1, 2, 3, 0, 0, 0 };
            int m = 3;
            int[] nums2 = new int[3] { 2, 5, 6 };
            int n = 3;
            
            Solution solution = new Solution();

            solution.Merge(nums1, m, nums2, n);

            Console.WriteLine(string.Join(", ", nums1));
        }
    }
}
