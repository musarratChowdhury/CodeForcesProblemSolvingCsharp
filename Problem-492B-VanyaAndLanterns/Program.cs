

using System;
using System.Collections.Generic;


namespace ProblemSolving

{
    public class Program
    {
        public static void Main(string[]  args)
        {
            //input
            var line1  = Console.ReadLine().Split(' ');
            var line2 = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(line1[0]);
            int l = Convert.ToInt32(line1[1]);
            //
            List<int> lanternLocations = new List<int>();
            for(int i = 0;i < n;i++)
            {
                lanternLocations.Add(Convert.ToInt32(line2[i]));
            }
            //lets sort the array at first
            lanternLocations.Sort();

            //then we will measure the distance from start and end position to the nearest lamp
            double DistanceFromStartPos = lanternLocations[0];
            double DistanceFromEndPos = l - lanternLocations[lanternLocations.Count-1];

            double maxDistanceFromStart_End = Math.Max(DistanceFromEndPos, DistanceFromStartPos);
            double maxDistanceINBetween = 0;
            

            //then we will measure the highest distance in between lamps
            for(int i = 1;i<n;i++)
            {
                if(lanternLocations[i]-lanternLocations[i-1]>maxDistanceINBetween)
                {
                    maxDistanceINBetween = lanternLocations[i] - lanternLocations[i - 1];
                  
                }
            }
            //finallly if the highest distance is in between then the answer is highest distance/2,as it willbe shared by two lamps
            //or else the start or end position has maximum distance so we will print it as it is because this distance will not be shared 
            if(maxDistanceFromStart_End>maxDistanceINBetween/2)
            {
                Console.WriteLine(maxDistanceFromStart_End);
            }else
            {
                Console.WriteLine(maxDistanceINBetween/2);
            }


        }
    }

}