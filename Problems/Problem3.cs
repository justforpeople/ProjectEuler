using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEuler.Problems
{
    /// <summary>
    /// Largest prime factor
    /// The prime factors of 13195 are 5, 7, 13 and 29.
    /// What is the largest prime factor of the number 600851475143 ?
    /// </summary>
    class Problem3:IProblem
    {
        public long GetAnswer()
        {
            long number = 666666600851475143;
            // solution 1
            //long max = number / 2;
            //for (long i = 2; i < max; i++)
            //{
            //    if (number % i == 0 && isPrime(number/i))
            //        return number/i;
            //}
            //return 0;

            // solution 2
            //long factor = 2;
            //long lastFactor = 1;
            //while (number > 1)
            //{
            //    if (number % factor == 0)
            //    {
            //        lastFactor = factor;
            //        number = number / factor;
            //        while (number % factor == 0)
            //        {
            //            number = number / factor;
            //        }
            //    }
            //    factor += 1;
            //}
            //return lastFactor;

            // solution 3
            //long lastFactor = 1;
            //if (number % 2 == 0)
            //{
            //    lastFactor = 2;
            //    number = number / 2;
            //    while (number % 2 == 0)
            //    {
            //        number = number / 2;
            //    }
            //}
            //else
            //{
            //    lastFactor = 1;
            //}
            //long factor = 3;
            //while (number > 1)
            //{
            //    if (number % factor == 0)
            //    {
            //        lastFactor = factor;
            //        number = number / factor;
            //        while (number % factor == 0)
            //        {
            //            number = number / factor;
            //        }
            //    }
            //    factor += 2;
            //}
            //return lastFactor;

            // solution 4
            long lastFactor = 1;
            if (number % 2 == 0)
            {
                lastFactor = 2;
                number = number / 2;
                while (number % 2 == 0)
                {
                    number = number / 2;
                }
            }
            else
            {
                lastFactor = 1;
            }
            long factor = 3;
            long maxFactor = (long)Math.Ceiling(Math.Pow(number, 0.5));
            while (number > 1 && factor <= maxFactor)
            {
                if (number % factor == 0)
                {
                    lastFactor = factor;
                    number = number / factor;
                    while (number % factor == 0)
                    {
                        number = number / factor;
                    }
                    maxFactor = (long)Math.Ceiling(Math.Pow(number, 0.5));
                }
                factor += 2;
            }
            if (number == 1)
            {
                return lastFactor;
            }
            else
            {
                return number;
            }
        }
        /// <summary>
        /// 是否质数
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        private bool isPrime(long number)
        {
            long max = (long)Math.Ceiling(Math.Pow(number, 0.5));
            for (long i = max; i > 1; i--)
            {
                if (number % i == 0)
                    return false;
            }
            return true;
        }
    }
}
