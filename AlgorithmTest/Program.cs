using System;
using AlgorithmLibrary;
using AlgorithmLibrary.DataStructure;
using static System.Console;
using System.Collections;


namespace AlgorithmTest
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            
            int number1 = 36;
            int number2 = 60;
            int[] testarr = {56,63,7,7,49,4,6,7,8,9,9};
            int[] testarr2 = {2,3,7,9,4};
            int[] testarr3 = {8,2,6,6,0};
            int[] testarr4 = new int[] { -1, -3, -4, 5, 6, 4, -3, 4, 1 };
            int[] testarr5 = { 1, 2, 3, 4, 5, -1, -2, -3, -3, -4, 1, 2, 3, 4, 5, 5, 6 };
             //int gcdofthem = Mathematics.GCDofTwoNumbers(number1,number2);
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
            //CustomLinkedList linkedList = new CustomLinkedList();
            //var firstNode = new CustomLinkedList.Node(3);
            //var secondNode = new CustomLinkedList.Node(4);
            //var thirdNode = new CustomLinkedList.Node(5);
            //var fourthNode = new CustomLinkedList.Node(5);

            //linkedList.head = firstNode;
            //firstNode.next = secondNode;
            //secondNode.next = thirdNode;
            //thirdNode.next = fourthNode;
            //
            // var result = AlgorithmLibrary.ArrayAlgo.MergeTwoArrays(testarr,testarr2,false);
            // Array.ForEach(result,System.Console.WriteLine);
            // queueAlgo.PrintBinaryNumbers(10);
            // stackAlgo.PrintNextGreaterElement(new int[]{15,8,4,10});
            //dictionaryAlgo.frequencyCalculator(new int[]{3,4,4,5,5,7,7,8,8,8,8,8,8,5,5,5,1,1,1,1});

            //Sorting.bubble_sort_ascending(testarr); 

            //foreach(int i in testarr)
            //{ Console.Write(i+" "); };

            //Console.WriteLine(Strings.KMPFindCount("asdfsadfasdfmasonasdfasdfxyzfdfxyzsadfasdfasxyz".ToCharArray(), "xyz".ToCharArray()));
            //Console.WriteLine(Strings.OrderMatch("sdfdsfaskdfjkalsdfs","akd"));

            //WriteLine(Strings.isUniqueChar("asdkuxzA"));

            //var result = ArrayAlgo.ContainsDuplicate(testarr);
            //WriteLine(result);
            //var resultSum = ArrayAlgo.MaxSubArraySum(testarr4).sum;

            //Array.ForEach(result, WriteLine);  
            //WriteLine("answer: "+resultSum);
            var nums1 =new int[] { 56, 63, 7, 0,0,0 };
            var n = 3;
           var  nums2= new int[] { 2, 5, 6 };
            var m = 3;
            Merge( nums1, m, nums2, n);
            //sortMyarr(nums1);

            foreach(var x in nums1)
            {
                WriteLine(x);
            }



            //var testArrSearch = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //foreach(var elem in testArrSearch)
            //{
            //    WriteLine($"Does {elem} exist? ");
            //    WriteLine(Search_Algorithm.DoesExist(testarr, elem));
            //}
            
            //WriteLine(asolResult[0], asolResult[1]);
          //return  asolResult.ToArray();
            //Array.ForEach(asolResult, WriteLine);

            //return result.ToArray();






        }
        public static void Merge(  int[] nums1, int m, int[] nums2, int n)
        {
            var listy = new List<int>(nums2);
            //listy.RemoveRange(n,m);
            for (int i = 0; i < m; i++)
            {
                listy.Add(nums1[i]);
            }



           Array.Copy(listy.ToArray(), nums1, listy.Count);
            Array.Sort(nums1);
           

            //Array.Clear(nums1);
            //nums1 =new int[] {};
            //nums1 = listy.ToArray();




        }
        public static void sortMyarr(int[] arr)
        {
            //
            Array.Sort(arr);
        }



    }
}
