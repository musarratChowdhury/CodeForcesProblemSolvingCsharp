using System;
using AlgorithmLibrary;
using AlgorithmLibrary.DataStructure;
using static System.Console;
using System.Collections;
using System.Text;

namespace AlgorithmTest
{
    class Program
    {
        static void Main(string[] args)
        {



            int number1 = 36;
            int number2 = 60;
            int[] testarr = { 56, 63, 7, 7, 49, 4, 6, 7, 8, 9, 9 };
            int[] testarr2 = { 2, 3, 7, 9, 4 };
            int[] testarr3 = { 8, 2, 6, 6, 0 };
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



            //var numbersArr= new int[] { 1, 3, 4, 5, 6, 6, 7, 7834, 345, 34, 45, 45, 4, 53, 45345, 345, 34, 553534, 553534, 4, 4, 5, 45, 4, 54, 5, 45 };

            //Array.Sort(numbersArr);
            //var printableArr = GetPrintableArray<int>(numbersArr);
            //WriteLine(printableArr);
            //var indexOfN = BinarySearch(numbersArr, 34);
            //WriteLine(indexOfN);


            //WriteLine(Search_Algorithm.Get_Sqrt(25));
            //WriteLine(Mathematics.GetPower(5, 2));


            //var intersectingElements =ArrayAlgo.Intersect(testarr, testarr2);
            //Array.ForEach(intersectingElements, WriteLine);


            var prices = new int[] { 3, 3, 5, 0, 0, 3, 1, 4 };


            //prices = prices.Where(x=>)

            //Array.Reverse(prices);
            var PossibleMaxProfit = MaxProfit(prices);

            //WriteLine(getMax(prices));


            //WriteLine(PossibleMaxProfit);

            var sortedArr = new int[] { 1, 2, 2, 2, 3, 4, 4, 4, 4, 7, 11 };

            WriteLine("Lower Bound  : {0}",arg0: Search_Algorithm.GetLowerBound(sortedArr, 4));
            WriteLine("Upper Bound  : {0}",arg0:Search_Algorithm.GetUpperBound(sortedArr, 4));
        }
        public static int MaxProfitON(int[] prices)
        {
            int maxProfit = 0;

            int[] auxArr = new int[prices.Length + 1];
            for (int i = 0; i < prices.Length;i++)
            {
                var maxSoFar = prices[i..].Max();
                auxArr[i] = maxSoFar;
            }

            for(int i = 0;i<prices.Length;i++)
            {
                var profit = auxArr[i] - prices[i];
                if(profit>maxProfit)
                {
                    maxProfit = profit;
                }
            }
            return maxProfit;
        }

        public static int MaxProfit(int[] prices)
        {
            int minimumSoFar = int.MaxValue;
            int PossibleMaxProfit = 0;

            for(int i = 0;i<prices.Length;i++)
            {
                if (prices[i]<minimumSoFar)
                {
                    minimumSoFar = prices[i];
                }
                int profit = prices[i] - minimumSoFar;
                if(profit>PossibleMaxProfit)
                    PossibleMaxProfit = profit; 
            }

            return PossibleMaxProfit;
        }
        static int getMax(int[] arr)
        {
            //Pair minmax = new Pair();
            int max = 0;

            int i;
            int n = arr.Length;

            /* If there is only one element
            then return it as min and max both*/
            if (n == 1)
            {
                max = arr[0];
                //minmax.min = arr[0];
                return max;
            }

            /* If there are more than one elements,
            then initialize min and max*/
            if (arr[0] > arr[1])
            {
                max = arr[0];
                //minmax.min = arr[1];
            }
            else
            {
                max = arr[1];
                //minmax.min = arr[0];
            }

            for (i = 2; i < n; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
              
            }
            return max;
        }

        public static int BinarySearch(int[] arr, int elem)
        {
            int L = 0, R = arr.Length - 1;

            while (L <= R)
            {
                int M = L + (R - L) / 2;

                if (arr[M] == elem) return M;
                else if (arr[M] > elem) R = M - 1;
                else L = M + 1;
            }

            return -1;
        }
        public static string GetPrintableArray<T>(T[] arr)
        {
            var sb = new StringBuilder();

            sb.Append("[");
            for (int i = 0; i < arr.Length; i++)
            {
                sb.Append(arr[i]?.ToString());
                //sb.Append(" ");
                if (i != arr.Length - 1)
                    sb.Append(",");
            }
            sb.Append("]");


            return sb.ToString();
        }
        public static void Merge(int[] nums1, int m, int[] nums2, int n)
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





    }
}
