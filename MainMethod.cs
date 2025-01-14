using System;
using System.Collections.Generic;
using System.Text;
//using HashSet.PairSum;
using BinarySearch.CuttingWood;

namespace AlgorithmReview
{
    class MainMethod
    {
        public static void Main()
        {
            int[] list = new int[] {232, 124, 456};
            int target = 7;

            int ans = Solution.CuttingWood(list, target);
            Console.WriteLine($"Ans is {ans}");
        }
    }
}
