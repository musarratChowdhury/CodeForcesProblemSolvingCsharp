
using System;
using static System.Console;
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
            var line1 = ReadLine().Split(" ");
            int a = Convert.ToInt32(line1[0]);
            int b = Convert.ToInt32(line1[1]);
            //var line2 = ReadLine().Split(" ");

            //necessary variables
            int numberOfdaysWDifferentSocks = 0;
            int numberOfDaysWSameSocks = 0;

            if (a > b)
            {
                numberOfdaysWDifferentSocks = b;
                //if ((a - b) % 2 == 0)
                    numberOfDaysWSameSocks = (a - b) / 2;
             
            }
            else if (b > a)
            {
                numberOfdaysWDifferentSocks = a;
               
                    numberOfDaysWSameSocks = (b-a)/2;
            }
            else
            {
                numberOfdaysWDifferentSocks = a;
                numberOfDaysWSameSocks = 0;
            }

            //solution
            Write(numberOfdaysWDifferentSocks);
            Write(" ");
            Write(numberOfDaysWSameSocks);



        }
    }
}