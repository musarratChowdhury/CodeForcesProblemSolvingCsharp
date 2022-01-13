using System;
using System.Collections.Generic;

namespace problem_469A
{
    class Program
    {
        static void Main(string[] args)
        {

            var inputN = Convert.ToInt32(Console.ReadLine());
            
            var inputL1 = Console.ReadLine().Split(' ');
            var inputL2 = Console.ReadLine().Split(' ');
            
            
            var uniqLevelArr = new List<int>();
           
           if(inputL1[0]!="0")
           {
                for(int i = 1;i<inputL1.Length;i++)
            {
                if(!uniqLevelArr.Contains(Convert.ToInt32(inputL1[i])))
                {
                    uniqLevelArr.Add(Convert.ToInt32(inputL1[i]));
                }
            }
           }
           if(inputL2[0]!="0")
           {
               for(int i = 1;i<inputL2.Length;i++)
            {
                if(!uniqLevelArr.Contains(Convert.ToInt32(inputL2[i])))
                {
                    uniqLevelArr.Add(Convert.ToInt32(inputL2[i]));
                }
            }
           }
           
            
            if(uniqLevelArr.Count == inputN)
           
                System.Console.WriteLine("I become the guy.");

            else 
            
                System.Console.WriteLine("Oh, my keyboard!");

           



        }
    }
}
