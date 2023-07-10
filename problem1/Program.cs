using System;

namespace problem1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Problem:
            // Given a non-negative integer, write a function to calculate the sum of its digits.
            //
            //     For example:
            // Input: 12345
            // Output: 15 (1 + 2 + 3 + 4 + 5 = 15)

            var input = 12345;
            var result = CalculateDigitSum(input);
            Console.WriteLine(result);
        }

        static int CalculateDigitSum(int number)
        {
            if (number < 10)
            {
                return number;
            }

            var lastDigit = number % 10;
            var remainingDigits = number / 10;

            return lastDigit + CalculateDigitSum(remainingDigits);
        }
    }
}