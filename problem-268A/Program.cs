using System;
using System.Collections.Generic;

namespace problem_268A
{
    class Program
    {
        class Team
        {
            public int H;
            public int A;
        }
        static void Main(string[] args)
        {
            var Teams = new List<Team>();
            var combinations = new List<(int H,int A)>();

            int n = Convert.ToInt32(Console.ReadLine());
            for(int i =0 ;i<n;i++)
            {
                var inputL = Console.ReadLine().Split(" ");
                Teams.Add(new Team(){H=Convert.ToInt32(inputL[0]),A=Convert.ToInt32(inputL[1])});
            }
            //getting all possible combinations
            for(int i = 0;i<n;i++)
            {
               for(int j=0;j<n;j++)
               {
                   if(i!=j)
                   combinations.Add((Teams[i].H,Teams[j].A));        
               }
            }

            int result= 0;
            foreach(var comb in combinations)
            {
                if(comb.H==comb.A)
                {
                    result++;
                }
            }
            System.Console.WriteLine(result);
            
            // foreach(var team in Teams)
            // {
            //     System.Console.WriteLine($"H:{team.H},A:{team.A}");
            // }
        }
    }
}
