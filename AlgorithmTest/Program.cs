using System;
using AlgorithmLibrary;
using AlgorithmLibrary.DataStructure;


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
            // Console.WriteLine(gcdofthem);
            // Console.WriteLine("gcd of the array : "+gcdOftheArr);
            // var result = Mathematics.FindAllPrimeFactors(number2,true);
            // var result = Mathematics.LCMofAnArrayOfNumbers(new int[]{1,2,8,3});
            // var PrimeNumbers = Mathematics.PrimeNumbers.GetAllPrimesTill(100);
            // Array.ForEach(PrimeNumbers,System.Console.WriteLine);
            // Console.WriteLine("total prime numbers got :  "+ PrimeNumbers.Length);
            // Console.WriteLine(Mathematics.PrimeNumbers.isPrime(33));
            // Mathematics.FindLargestMultipleOf3(new int[]{3,0,5,6,7,8,9,9});
            // var result = ArrayAlgo.RotateArrayLeft(testarr2);
            // result = ArrayAlgo.RotateArrayRight(testarr2);
            // Array.ForEach(result,Console.WriteLine);

            // System.Console.WriteLine(   result);
            //linked list
            CustomLinkedList linkedList = new CustomLinkedList();
            var firstNode = new CustomLinkedList.Node(3);
            var secondNode = new CustomLinkedList.Node(4);
            var thirdNode = new CustomLinkedList.Node(5);
            var fourthNode = new CustomLinkedList.Node(5);

            linkedList.head = firstNode;
            firstNode.next = secondNode;
            secondNode.next = thirdNode;
            thirdNode.next = fourthNode;
            //
            // var result = AlgorithmLibrary.ArrayAlgo.MergeTwoArrays(testarr,testarr2,false);
            // Array.ForEach(result,System.Console.WriteLine);
            // queueAlgo.PrintBinaryNumbers(10);
            // stackAlgo.PrintNextGreaterElement(new int[]{15,8,4,10});
            dictionaryAlgo.frequencyCalculator(new int[]{3,4,4,5,5,7,7,8,8,8,8,8,8,5,5,5,1,1,1,1});
        }
    }
}
