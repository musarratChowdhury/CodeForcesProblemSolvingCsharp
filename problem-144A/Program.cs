using System;
using System.Collections.Generic;

namespace problem_144A
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            var inputN = Console.ReadLine();
            var inputL = Console.ReadLine().Split(" ");
            var listy = new List<int>();
            foreach(string i in inputL)
            {
                listy.Add(Convert.ToInt32(i));
            }
            var min = MinOfGivenNumbers(listy.ToArray());
           var max  = MaxOfGivenNumbers(listy.ToArray());
           int minIndex = 0;
           int maxIndex = 0;
           int desiredIndexforMinm = listy.Count -1;
           int desiredIndexforMaxm = 0;
           int stepsNeededtOmoveMinm  = 0;
           int stepsNeededtoMoveMaxm = 0;
            for(int i = 0;i<listy.Count;i++)
            {
                if(listy[i]==max)
                {
                    maxIndex = i;
                    break;
                }
            }
            int midPoint = listy.Count/2;
            // System.Console.WriteLine("max Index"+maxIndex);
            // System.Console.WriteLine("mid point "+midPoint);
            for(int i  = listy.Count-1;i>=0;i--)
            {
                if(listy[i]==min)
                {
                    minIndex = i;
                    break;
                }
            }
            // System.Console.WriteLine("min Index"+minIndex);

            

            stepsNeededtoMoveMaxm = Math.Abs(desiredIndexforMaxm - maxIndex);
            // System.Console.WriteLine("distance from left end to max "+stepsNeededtoMoveMaxm);
            stepsNeededtOmoveMinm = Math.Abs(desiredIndexforMinm - minIndex);
            // System.Console.WriteLine("distance form right end to min "+stepsNeededtOmoveMinm);
            int result = stepsNeededtoMoveMaxm+stepsNeededtOmoveMinm;
            if(minIndex<maxIndex)
            {
                result--;
            }

            System.Console.WriteLine(result);


        


        }
        public static int MinOfGivenNumbers(int[] input)
      {
         int min = input[0];
         for(int i = 1;i<input.Length;i++)
         {
            if(min>input[i])
            {
               min = input[i];
            }
         }
         return min;
      }
      public static int MaxOfGivenNumbers(int[] input)
      {
         int max = input[0];
         for(int i = 1;i<input.Length;i++)
         {
            if(max<input[i])
            {
               max = input[i];
            }
         }
         return max;
      }

    }
}
