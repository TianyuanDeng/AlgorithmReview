using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmReview
{
    class SeparatingString
    {
        public static void SeperateString()
        {
            /*
            string phrase = "this is a new word";
            string[] words = phrase.Split(' ');

            foreach (var word in words)
            {
                Console.WriteLine(word);
            }


            char[] delimitersChars = { ' ', ',', '.', ':', '\t' };

            int[] arrMyValues = new int[] { 5, 1, 22, 25, 6, -1, 8, 10 };
            List<int> ar = new List<int>(arrMyValues);
            List<int> sq = new List<int>();
            sq.Add(25);
            subSequence.IsValidSubsequence(ar, sq);*/

            //int[] arrMyValues = new int[] { 15 , 1, 2, 4, 16, 2, 15};
            //FirstMissingNumber.firstMissingPositive(arrMyValues);

            //quickSort.QuickSort(arrMyValues);
            //Array.ForEach(arrMyValues, Console.WriteLine);

            String s = "A man, a plan, a canal: Panama";
            if (validPalindrome.IsPalindrome(s))
            {
                Console.WriteLine("True");
            }else
            {
                Console.WriteLine("False");
            }

        }
    }
}
