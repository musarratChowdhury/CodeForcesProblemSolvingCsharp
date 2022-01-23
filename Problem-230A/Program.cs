
using System;
using System.Collections.Generic;

namespace ProblemSolving

{
    public class DragonComparer : IComparer<(int strength, int bonus)>
    {
        public int Compare((int strength, int bonus) x, (int strength, int bonus) y)
        {
            if(x.strength ==y.strength)
            {
                return 0;
            }
            else if(x.strength <y.strength)
            {
                return -1;
            }
            else
            {
                return 1;
            }
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            //input
            var line1 = Console.ReadLine().Split(" ");
            int s = int.Parse(line1[0]);    
            int n = int.Parse(line1[1]);
            //collection
            List<(int strength, int bonus)> dragons = new List<(int strength, int bonus)>();
            

            for(int i = 0; i < n;i++)
            {
                var dragonStrength = Console.ReadLine().Split(" ");
                int strength = int.Parse(dragonStrength[0]);
                int bonus = int.Parse(dragonStrength[1]);
                dragons.Add((strength, bonus));

            }
            var sortedDragons = dragons.ToArray();
            Array.Sort(sortedDragons,new DragonComparer());

            foreach(var dragon in sortedDragons)
            {
                if(s>dragon.strength)
                {
                    s += dragon.bonus;
                }
                else
                {
                    Console.WriteLine("NO");
                    return;
                }
            }
            Console.WriteLine("YES");
        }
    }

}
