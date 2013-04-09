using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEuler.Problems
{
    /// <summary>
    /// Smallest multiple
    /// 2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
    /// What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?
    /// </summary>
    class Problem5:IProblem
    {
        public long GetAnswer()
        {
            int[] array = new int[31];
            for (int i = 30; i > 1; i--)
            {
                int temp = i;
                for (int j = 2; j <= i; j++)
                {
                    int count = 0;
                    while (temp % j == 0)
                    {
                        count += 1;
                        temp /= j;
                    }
                    if (count > 0 && count > array[j])
                    {
                        array[j] = count;
                    }
                    if (temp == 1)
                        break;
                }
            }
            long sum = 1;
            for (int i = 2; i <= 30; i++)
            {
                if (array[i] > 0)
                {
                    sum *= (long)Math.Pow(i, array[i]);
                }
            }
            return sum;
        }
    }
}
