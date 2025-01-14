using System;
using System.Collections.Generic;
using System.Linq;

namespace SortString.TopKWords{
    public static class Solution {
        /*Given an array of strings words and an integer k, return the k most frequent strings.
Return the answer sorted by the frequency from highest to lowest. Sort the words with the same frequency by their lexicographical order.*/
        public static IList<string> TopKFrequent(string[] words, int k) {
            Dictionary<string, int> dic = new Dictionary<string, int>();

            foreach(var word in words){
                if (!dic.ContainsKey(word)){
                    dic[word] = 0;
                }

                dic[word]++;
            }

            var sortedword = dic.Keys.ToList();
            sortedword.Sort((a, b) => {
                if (dic[a] == dic[b]){
                    return String.Compare(a, b);
                }
                return dic[b] - dic[a]; 
                //default sorting algorithm, for descending order
                //Ascending order will be a - b 
            });

            return sortedword.Take(k).ToList(); 
        }
    }
}