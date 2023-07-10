using System;

namespace Fibonacci
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var result = Fibonacci(40);
            Console.WriteLine(result);
        }

        static int Fibonacci(int n)
        {
            if (n == 0)
            {
                return 0;
            }

            if (n == 1)
            {
                return 1;
            }

            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }
}