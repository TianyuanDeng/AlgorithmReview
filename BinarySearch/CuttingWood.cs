using System;
using System.Reflection;

namespace BinarySearch.CuttingWood {
    public static class Solution{
        public static int CuttingWood(int[] trees, int amount){
            int maxHeight = 0, bestHeight = 0;
            
            foreach (var i in trees){
                maxHeight = Math.Max(maxHeight, i);
            }

            int left = 1, right = maxHeight;
            Console.WriteLine(right);

            while (left < right){
                int mid = left + (right - left) / 2;


                Console.WriteLine($"Left is {left}, Right is {right}");
                Console.WriteLine($"Mid is {mid}");

                if (checkTree(trees, mid, amount)){
                    bestHeight = mid;
                    left = mid + 1;
                }else {
                    right = mid - 1;
                }
            }

            return bestHeight;
        }

        public static bool checkTree(int[] trees, int cutPoint, int amount){
            int total = 0;
            foreach (var i in trees){
                if (i > cutPoint)
                {
                    total += i - cutPoint;
                }
            }

            Console.WriteLine($"Total is {total}, Amount is {amount}");
            return total >= amount; 
        }
    }
}