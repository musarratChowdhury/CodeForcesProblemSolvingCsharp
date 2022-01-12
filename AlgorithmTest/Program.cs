using System;
using AlgorithmLibrary;


namespace AlgorithmTest
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            
            int number1 = 36;
            int number2 = 60;
            int[] testarr = {56,63,7,7,49};
            int[] testarr2 = {2,3,7,9,4};
            int[] testarr3 = {8,2,6,6,0};
            int gcdofthem = Mathematics.GCDofTwoNumbers(number1,number2);
            // int? gcdOftheArr = Mathematics.GCDofAnArrayOFNumbers(testarr);
            // System.Console.WriteLine(gcdofthem);
            // System.Console.WriteLine("gcd of the array : "+gcdOftheArr);
            // var result = Mathematics.FindAllPrimeFactors(number2,true);
            // var result = Mathematics.LCMofAnArrayOfNumbers(new int[]{1,2,8,3});
            // var PrimeNumbers = Mathematics.PrimeNumbers.GetAllPrimesTill(100);
            // Array.ForEach(PrimeNumbers,System.Console.WriteLine);
            // System.Console.WriteLine("total prime numbers got :  "+ PrimeNumbers.Length);
            // System.Console.WriteLine(Mathematics.PrimeNumbers.isPrime(33));
            Mathematics.FindLargestMultipleOf3(new int[]{3,0,5,6,7,8,9,9});

            // System.Console.WriteLine(   result);
        }
    }
}
