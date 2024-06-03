using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmReview
{
    class CountChar
    {
        static void printCharWithFreq(String str)
        {
            int[] characters = new int[26];
            String input = "aaabbcaa";

            foreach (char s in input)
            {
                characters[s - 'a']++;
            }

            foreach (char s in input)
            {
                if (characters[s - 'a'] > 0)
                {
                    Console.WriteLine(s);
                    Console.WriteLine(characters[s - 'a'] + " ");
                }

                characters[s - 'a'] = 0;
            }
        }
    }
}
