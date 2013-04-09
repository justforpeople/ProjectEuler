using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

using ProjectEuler.Problems;
using ProjectEuler.OtherProblems;

namespace ProjectEuler
{
    class Program
    {
        static void Main(string[] args)
        {
            IProblem problem = new MoneyChange();
            Stopwatch s = new Stopwatch();
            s.Start();
            long result = problem.GetAnswer();
            s.Stop();
            Console.WriteLine("耗时："+s.ElapsedMilliseconds + ",-------" + result);
            Console.ReadLine();
        }
    }
}
