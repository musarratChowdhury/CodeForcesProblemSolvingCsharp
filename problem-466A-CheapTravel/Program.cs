using System;

namespace problem_466A_CheapTravel
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Ann has recently started commuting by subway. We know that a one ride subway ticket
            // costs a rubles. Besides, Ann found out that she can buy a special ticket for m rides
            // (she can buy it several times). It costs b rubles. Ann did the math; she will need to use
            // subway n times. Help Ann, tell her what is the minimum sum of money she will have to spend
            // to make n rides?
            //
            //     Input
            // The single line contains four space-separated integers n, m, a, b (1 ≤ n,m, a, b ≤ 1000) — the
            // number of rides Ann has planned, the number of rides covered by the m ride ticket, the price of a
            // one ride ticket and the price of an m ride ticket.
            //
            //     Output
            //     Print a single integer — the minimum sum in rubles that Ann will need to spend.
            
            string[] input = Console.ReadLine().Split();
            int n = int.Parse(input[0]); //number of rides
            int m = int.Parse(input[1]); //the number of rides covered by the m ride ticket
            int a = int.Parse(input[2]); //the price of a one ride ticket 
            int b = int.Parse(input[3]); //the price of an m ride ticket

            int totalCost = 0;
            
            //n * a || 
            
        }
    }
}