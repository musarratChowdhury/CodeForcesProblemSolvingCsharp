using System;
using System.Collections.Generic;
using System.Linq;

namespace FindingPrimeNumbers
{
    internal class Program
    { 
        public static void Main(string[] args)
        {
            var result = MakeSieve(40);
            var totalNumberOfPrimes = result.Count(x => x == true);
            var listOfThePrimes = new List<int>();

            for (int i = 2; i < result.Count(); i++)
            {
                if (result[i])
                {
                    listOfThePrimes.Add(i);
                }
            }
            
            Console.WriteLine(totalNumberOfPrimes);
            Console.WriteLine("-----------------");
            listOfThePrimes.ForEach(x=>Console.WriteLine(x));
        }

        // Use the Sieve of Eratosthenes to find prime numbers in C#
        public static bool[] MakeSieve(int max)
        {
            bool[] isPrime = new bool[max + 1];
            isPrime[2] = true;

            for (int i = 3; i <= max; i += 2)
            {
                isPrime[i] = true;
            }
            
            // Cross out multiples of odd primes.
            for (int i = 3; i <= max; i += 2)
            {
                // See if i is prime.
                if (isPrime[i])
                {
                    // Knock out multiples of i.
                    for (int j = i * 3; j <= max; j += i)
                        isPrime[j] = false;
                }
            }
            return isPrime;

        }
        
    }
}