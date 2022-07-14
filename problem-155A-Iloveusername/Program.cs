



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
            var n = Convert.ToInt32(Console.ReadLine());   
            var line2 = Console.ReadLine().Split(" ");

            //necessary variables

            int max = Convert.ToInt32(line2[0]);
            int min = Convert.ToInt32(line2[0]);
            int cnt = 0;
            //int nextNumber = 0;
              
            for(int i = 0; i<line2.Length;i++)
            {
                int number = Convert.ToInt32(line2[i]); 
                
                if(number>max)
                {
                    max = number;
                    cnt++;
                }
                if(number<min)
                {
                    min = number;
                    cnt++;
                }
            }
            Console.WriteLine(cnt);


            //solution



        }
    }
}
