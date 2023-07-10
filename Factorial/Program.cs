using System;

namespace Factorial
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var result = Factorial(3);
            Console.WriteLine(result);
        }

        static int Factorial(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            return n * Factorial(n - 1);
        }
    }
}