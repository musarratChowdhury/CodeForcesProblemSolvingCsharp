
using System;
using System.Text;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace problem
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            var line1 = Console.ReadLine().Split(" ");
            int n = Convert.ToInt32(line1[0]);
            int k = Convert.ToInt32(line1[1]);


            //necessary variables
            int timePerProblem = 5;
            int totalTimeToSolveProblems = 0;

            for(int i = 1; i <= n; i++)
            {
                totalTimeToSolveProblems += (i * timePerProblem);
            }


            //solution



        }
    }
}