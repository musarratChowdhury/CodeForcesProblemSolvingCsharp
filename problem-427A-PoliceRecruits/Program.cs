
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
            //var line1 = Console.ReadLine().Split(" ");
            int n = Convert.ToInt32(ReadLine()); 
            //int m = Convert.ToInt32(line1[1]);
            var line2 = ReadLine().Split(" ");


            //necessary variables
            int numberOfuntreatedCrimes = 0;
            int currentlyAvailableOfficers = 0;

            //solution
            for(int i = 0; i < n; i++)
            {
                var number = int.Parse(line2[i]);
                //
                if(number==-1)
                {
                    if(currentlyAvailableOfficers>0)
                    {
                        //atleast one officer is available
                        //they will investigate the case;
                        currentlyAvailableOfficers--;

                    }
                    else
                    {
                        numberOfuntreatedCrimes++;
                    }
                }
                else
                {
                    currentlyAvailableOfficers += number;
                }

            }
            WriteLine(numberOfuntreatedCrimes);



        }
    }
}