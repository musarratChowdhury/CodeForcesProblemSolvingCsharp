
using System;

using System.Text;
using System.Linq;
using System.Threading;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

namespace problem
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            var t = Convert.ToInt32(Console.ReadLine());
            var listy = new int[t][];
           
            for(int i = 0; i < t; i++)
            {
                var testcase = Convert.ToInt32(Console.ReadLine());

                if(isRound(testcase))
                {
                    listy[i]=(new int[] {testcase});
                }
                else
                {
                    //break into parts and get the number of parts
                    var BrokenParts = BreakIntoParts(testcase);
                    listy[i]=(BrokenParts.ToArray());
                }
                

            }



            //necessary variables


            //solution

            foreach(var keyValue in listy)
            {
                Console.WriteLine(keyValue.Length);
                foreach(var v in keyValue)
                {
                    Console.Write(v);
                    Console.Write(" ");
                }
               Console.WriteLine();
            }



        }
        static List<int> BreakIntoParts(int num)
        {
            var parts = new List<int>();
            //var partsCount = (int)DateTime.Now.Ticks;
            var digitCount = 0;
            while(num>0)
            {
                int modulus = num % 10;
                if (modulus != 0) 
                parts.Add(modulus*((int)Math.Pow(10,digitCount)));
                num/=10;
                //partsCount++;
                digitCount++;
            }
            return parts;
        }

        static bool isRound(int num)
        {
            int digits = num.ToString().Length;
            int divisor = (int)Math.Pow(10, digits-1);
            if (num % divisor == 0)
                return true;
            else 
                return false;
        }
    }
}