using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmReview
{
    class subSequence
    {
		public static bool IsValidSubsequence(List<int> array, List<int> sequence)
		{
			int pointer = 0;

			foreach (var n in array) {
				if (n == sequence[pointer])
                {
					pointer++;
                }

				if (pointer == sequence.Count)
				{
					return false;
				}
			}


			return false;
		}
	}
}
