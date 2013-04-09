using System;
using System.Collections.Generic;
using System.Text;

using ProjectEuler.Problems;

namespace ProjectEuler.OtherProblems
{
    /// <summary>
    /// 将10000块钱兑换成由5000块、2000块、1000块、500块、100块、50块、10块、5块、1块的组成的零钱，问有多少种兑换方式？
    /// </summary>
    class MoneyChange : IProblem
    {
        //long IProblem.GetAnswer()
        //{
        //    long count = 0;
        //    //long tmp = 0;
        //    for (int i = 0; i <= 2; i++)
        //    {
        //        int i1 = (10000 - 5000 * i) / 2000;
        //        for (int j = 0; j <= i1; j++)
        //        {
        //            int j1 = (10000 - 5000 * i - 2000 * j) / 1000;
        //            for (int k = 0; k <= j1; k++)
        //            {
        //                int k1 = (10000 - 5000 * i - 2000 * j - 1000 * k) / 500;
        //                for (int x = 0; x <= k1; x++)
        //                {
        //                    int x1 = (10000 - 5000 * i - 2000 * j - 1000 * k - 500 * x) / 100;
        //                    for (int y = 0; y <= x1; y++)
        //                    {
        //                        int y1 = (10000 - 5000 * i - 2000 * j - 1000 * k - 500 * x - 100 * y) / 50;
        //                        for (int z = 0; z <= y1; z++)
        //                        {
        //                            int z1 = (10000 - 5000 * i - 2000 * j - 1000 * k - 500 * x - 100 * y - 50 * z) / 10;
        //                            for (int ii = 0; ii <= z1; ii++)
        //                            {
        //                                int ii1 = (10000 - 5000 * i - 2000 * j - 1000 * k - 500 * x - 100 * y - 50 * z - 10 * ii) / 5;
        //                                //for (int jj = 0; jj <= ii1; jj++)
        //                                //{
        //                                    //int jj1 = (10000 - 5000 * i - 2000 * j - 1000 * k - 500 * x - 100 * y - 50 * z - 10 * ii - 5 * jj);
        //                                    //for (int kk = 0; kk <= jj1; kk += 5)
        //                                    //{
        //                                    //    //tmp++;
        //                                    //    if (5000 * i + 2000 * j + 1000 * k + 500 * x + 100 * y + 50 * z + 10 * ii + 5 * jj + kk == 10000)
        //                                    //    {
        //                                    //        count++;
        //                                    //    }
        //                                    //}
        //                                    //if (jj1 >= 0)
        //                                    //{
        //                                        //count++;
        //                                    //}
        //                                //}
        //                                count += ii1 + 1;
        //                            }
        //                        }
        //                    }
        //                }
        //            }
        //        }
        //    }
        //    return count;
        //}

        private int[] x = new int[] { 0, 5000, 2000, 1000, 500, 100, 50, 10, 5, 1 };
        /// <summary>
        /// 递归法
        /// </summary>
        /// <returns></returns>
        public long GetAnswer()
        {
            return solve(10000, 1);
        }
        private long solve(int value, int index)
        {
            if (value == 0)
                return 1;
            if (index == 8)
                return value / 5 + 1;
            long count = 0;
            for (int i = 0; i * x[index] <= value; i++)
                count += solve(value - i * x[index], index + 1);
            return count;
        }
    }
}
