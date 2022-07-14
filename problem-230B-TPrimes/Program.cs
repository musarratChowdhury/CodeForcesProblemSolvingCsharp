
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
            var n = Convert.ToInt32(ReadLine());
            var line2 = ReadLine().Split(" ");
            
            long range = (long)Math.Pow(10, 6);

            int[] a = new int[range + 1];

            for (int i = 2; i <= range; i++)
            {
                if (a[i] == 0)
                {
                    for (int j = 2; i * j <= range; j++)
                    {
                        a[i * j] = 1;
                    }
                }
            }
            foreach (var x in line2)
            {
                var number = Convert.ToInt64(x);
               
                 var sqrt = Math.Sqrt(number);
                if(number==1)
                {
                    WriteLine("NO");
                   
                }

                else if (sqrt == (long)sqrt)
                {

                    if (a[(long)sqrt]==0)
                    {

                        WriteLine("YES");
                    }
                    else
                    {
                        WriteLine("NO");
                    }
                }
                else
                {
                    WriteLine("NO");
                }
            };
            

       

        }
       
       
       
       
    }
}