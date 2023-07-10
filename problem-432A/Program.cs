using System;
using System.Collections.Generic;
using System.Linq;

namespace problem_432A
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // The Saratov State University Olympiad Programmers Training Center (SSU OPTC) has n students.
            // For each student you know the number of times he/she has participated in the ACM ICPC world
            // programming championship. According to the ACM ICPC rules, each person can participate in the
            // world championship at most 5 times.
            //
            //     The head of the SSU OPTC is recently gathering teams to participate in the world
            // championship. Each team must consist of exactly three people, at that, any person cannot
            // be a member of two or more teams. What maximum number of teams can the head make if he wants
            // each team to participate in the world championship with the same members at least k times?
            //
            //     Input
            // The first line contains two integers, n and k (1 ≤ n ≤ 2000; 1 ≤ k ≤ 5).
            // The next line contains n integers: y1, y2, ..., yn (0 ≤ yi ≤ 5),
            // where yi shows the number of times the i-th person participated in the ACM ICPC world championship.
            //
            //     Output
            //     Print a single number — the answer to the problem.
            
            string[] input = Console.ReadLine().Split();
            int n = int.Parse(input[0]); //number of people
            int k = int.Parse(input[1]); //minimum participation

            int[] participationCounts = Console.ReadLine().Split()
                .Select(int.Parse)
                .OrderBy(x => x)
                .ToArray();

            int numTeams = 0;
            
            //first we can find out how many people are eligible to participate k times
            //if only 3 people is eligible then the answer is 1
            //if the number of people is less than 3 then the answer is 0;
            //if the number of people is more than 3 but less than the multiples of 3 then answer is 1;
            // or if equal to a multiple of 3 then the number of team is number of people/3;

            var participationCountAfterAddingKtimes = participationCounts.Select(x => x + k);
            var eligibleParticipants = participationCountAfterAddingKtimes.Where(x => x <= 5);
           
            numTeams = eligibleParticipants.Count() / 3;
            
            Console.WriteLine(numTeams);
        }
    }
}