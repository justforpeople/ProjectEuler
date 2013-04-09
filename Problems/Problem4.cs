using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEuler.Problems
{
    /// <summary>
    /// Largest palindrome product
    /// A palindromic number reads the same both ways. 
    /// The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 99.
    /// Find the largest palindrome made from the product of two 3-digit numbers.
    /// </summary>
    class Problem4:IProblem
    {
        private long x = 10000;
        private long y = 99999;
        public long GetAnswer()
        {
            // solution 1
            //long min = x * x;
            //long max = y * y;
            //long number = 0;
            //for (long i = y; i >= x; i--)
            //{
            //    //number = i / 100 * 100001 + (i % 100) / 10 * 10010 + (i % 10) * 1100;
            //    //number = i / 1000 * 10000001 + (i % 1000) / 100 * 1000010 + (i % 100) / 10 * 100100 + (i % 10) * 11000;
            //    number = i / 10000 * 1000000001 + (i % 10000) / 1000 * 100000010 + (i % 1000) / 100 * 10000100 + (i % 100) / 10 * 1001000 + (i % 10) * 110000;
            //    if (number <= max && number >= min && isInRange(number))
            //    {
            //        return number;
            //    }
            //}
            //return 0;

            long largestPalindrome = 0;
            long a = 999;
            long b = 0;
            int db = 0;
            while (a >= 100)
            {
                if (a % 11 == 0)
                {
                    b = 999;
                    db = 1;
                }
                else
                {
                    b = 990;
                    db = 11;
                }
                while (b >= a)
                {
                    if (b * a <= largestPalindrome)
                        break;
                    if (IsPalindrome(a * b))
                        largestPalindrome = a * b;
                    b -= db;
                }
                a -= 1;
            }
            return largestPalindrome;
        }
        /// <summary>
        /// 是否为两个三位数的乘积
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        private bool isInRange(long number)
        {
            // solution 1
            //for (long i = x; i <= y; i++)
            //{
            //    for (long j = x; j <= y; j++)
            //    {
            //        if (number == i * j)
            //        {
            //            this.x = i;
            //            this.y = j;
            //            return true;
            //        }
            //    }
            //}
            // solution 2
            long factor;
            for (long i = y; i >= x; i--)
            {
                if (number % i == 0)
                {
                    factor = number / i;
                    if (factor >= x && factor <= y)
                    {
                        this.x = i;
                        this.y = factor;
                        return true;
                    }
                }
            }
            return false;
        }
        /// <summary>
        /// 得到某数的反转
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        private long Reverse(long number)
        {
            long reversed = 0;
            while (number > 0)
            {
                reversed = reversed * 10 + number % 10;
                number = number / 10;
            }
            return reversed;
        }
        /// <summary>
        /// 是否回文数
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        private bool IsPalindrome(long number)
        {
            return number == Reverse(number);
        }
    }
}
