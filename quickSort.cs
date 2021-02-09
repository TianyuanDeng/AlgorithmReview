using System;
using System.Collections.Generic;
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
    }
}
