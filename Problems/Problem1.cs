using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEuler.Problems
{
    /// <summary>
    /// Multiples of 3 and 5
    /// If we list all the natural numbers below 10 that are multiples of 3 or 5, 
    /// we get 3, 5, 6 and 9. The sum of these multiples is 23.
    /// Find the sum of all the multiples of 3 or 5 below 1000.
    /// </summary>
    class Problem1:IProblem
    {
        public long GetAnswer()
        {
            long number = 100000000;
            return DivisionSum(number, 3) + DivisionSum(number, 7) - DivisionSum(number, 21);
        }
        /// <summary>
        /// 得到number以下能除尽division的数的总和
        /// </summary>
        /// <param name="number"></param>
        /// <param name="division"></param>
        /// <returns></returns>
        private long DivisionSum(long number, int division)
        {
            long count = (number - 1) / division;
            return division * count * (count + 1) / 2;
        }
    }
}
