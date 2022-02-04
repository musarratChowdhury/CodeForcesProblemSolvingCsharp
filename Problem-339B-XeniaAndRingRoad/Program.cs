
using System;
using System.Collections.Generic;
namespace problem_337A
{
    class Program
    {
        static void Main(string[] args)
        {
            var line1 = Console.ReadLine().Split(" ");
            long n = Convert.ToInt32(line1[0]);
            long m = Convert.ToInt64(line1[1]);
            var line2 = Console.ReadLine().Split(" ");

            //
            long prevPos = 1;
            long time = 0;
            //
            for (long i = 0; i < m; i++)
            {
                long presentPos = Convert.ToInt64(line2[i]);

                if (presentPos > prevPos)
                {
                    time += (presentPos - prevPos);
                }
                else if (presentPos < prevPos)
                {
                    time += n - prevPos + presentPos;
                }
                else
                {
                    continue;
                }

                prevPos = presentPos;
            }

            Console.WriteLine(time);


        }
    }
}