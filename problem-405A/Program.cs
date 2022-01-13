using System;
using System.Collections.Generic;
//Gravity flip
namespace problem_405A
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputN = Convert.ToInt32(Console.ReadLine());
            var inputL = Console.ReadLine().Split(' ');
            //
            var listy = new List<int>();
            for(int i = 0;i<inputN;i++)
            {
                var number = Convert.ToInt32(inputL[i]);
                listy.Add(number);
            }
            listy.Sort();
          
            foreach(var i in listy)
            {
                System.Console.Write(i+" ");
            }
        }
    }
}
