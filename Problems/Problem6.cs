using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEuler.Problems
{
    /// <summary>
    /// Sum square difference
    /// The sum of the squares of the first ten natural numbers is,
    /// 12 + 22 + ... + 102 = 385
    /// The square of the sum of the first ten natural numbers is,
    /// (1 + 2 + ... + 10)2 = 552 = 3025
    /// Hence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is 3025  385 = 2640.
    /// Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.
    /// </summary>
    class Problem6 : IProblem
    {
        public long GetAnswer()
        {
            //long number1 = 0;
            //long number2 = 0;
            //for (int i = 1; i <= 100; i++)
            //{
            //    number1 += (long)Math.Pow(i, 2);
            //}
            //number2 = (long)Math.Pow(5050, 2);
            //return number2 - number1;
            return 100 * (100 + 1) / 2 * (100 * (100 + 1) / 2 - (2 * 100 + 1) / 3);
        }
    }
}
