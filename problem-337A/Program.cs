using System;
using System.Collections.Generic;
namespace problem_337A
{
    class Program
    {
        static void Main(string[] args)
        {
            var line1 = Console.ReadLine().Split(" ");
            int n = Convert.ToInt32(line1[0]);
            int m =  Convert.ToInt32(line1[1]);

            var line2 = Console.ReadLine().Split(" ");

            var puzzles = new List<int>();
            foreach(var i in line2)
            {
                puzzles.Add(Convert.ToInt32(i));
            }

            puzzles.Sort();
           

            int extraPuzzel = m - n;

            int min = 999999;

            for(int i = 0;i<extraPuzzel+1;i++){
              
              int PuzzleA = puzzles[i];
              int PuzzleB = puzzles[i+n-1];

              if(PuzzleB - PuzzleA<min)
              {
                  min = PuzzleB -PuzzleA;
              }        
            }
            System.Console.WriteLine(min);
           
           
    }
  }
}