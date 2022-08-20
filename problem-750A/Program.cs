
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
            int i = 0;
            while(totalTimeToSolveProblems+k<=240)
            {
                if (i >= n || (totalTimeToSolveProblems + ((i+1) * timePerProblem)+k) > 240) break;
                i++;

                totalTimeToSolveProblems += (i * timePerProblem);
            }
            Console.WriteLine(i);

            //solution



        }
    }
}