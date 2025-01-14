using System;

namespace BitOperation  {

    class BitOperation {
        public static void printOddTimesNum2(int[] arr) {
            int eor = 0;

            foreach (int curNumm in arr){
                eor ^= curNumm;
            }

            int rightOne = eor & (~eor + 1);
            
        }
    }

}