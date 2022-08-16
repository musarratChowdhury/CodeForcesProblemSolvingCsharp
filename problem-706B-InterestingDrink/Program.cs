using System;
using static System.Console;


namespace problem_706B_InterestingDrink
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(ReadLine());
            var pricesOfBottlesInput = ReadLine().Split(" ");
            int[] pricesOfBottles = new int[pricesOfBottlesInput.Length];
            List<int> results = new();
            for(int i = 0;i<pricesOfBottlesInput.Length;i++)
            {
                pricesOfBottles[i] = (Convert.ToInt32(pricesOfBottlesInput[i]));
            }
            Array.Sort(pricesOfBottles);

            int q = Convert.ToInt32(ReadLine());
            for(int i = 0;i<q;i++)
            {
                var mi = Convert.ToInt32(ReadLine());
               
                var count =GetUpperBound(pricesOfBottles, mi);
               
                results.Add(count);
            }

            foreach(var x in results)
            {
                WriteLine(x);
            }

        }
        public static int GetUpperBound(int[] arr, int value)
        {
            int L = 0;
            int R = arr.Length;
            while (L < R)
            {
                int M = L + (R - L) / 2;
                if (arr[M] > value)
                {
                    R = M;
                }
                else
                {
                    L = M + 1;
                }

            }
            return L;
        }
    }
}