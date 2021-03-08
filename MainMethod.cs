using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmReview
{
    class MainMethod
    {
        public static void Main()
        {
            String s = "aaAbcd,!";
            if (CheckDuplacte.CheckDuplactedChar(s))
            {
                Console.WriteLine("No, it does not have duplacted char");
            }else
            {
                Console.WriteLine("Yes, it has duplacted char");
            }
        }
    }
}
