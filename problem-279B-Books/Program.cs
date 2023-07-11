using System;
using System.Security.Cryptography.X509Certificates;

namespace problem_279B_Books
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // When Valera has got some free time, he goes to the library to read some books.
            // Today he's got t free minutes to read. That's why Valera took n books in the library
            // and for each book he estimated the time he is going to need to read it. Let's number the
            // books by integers from 1 to n. Valera needs ai minutes to read the i-th book.
            //
            //     Valera decided to choose an arbitrary book with number i and read the books one by one,
            // starting from this book. In other words, he will first read book number i, then book number
            // i+1, then book number i+2 and so on. He continues the process until he either
            // runs out of the free time or finishes reading the n-th book. Valera reads each book up to the end,
            // that is, he doesn't start reading the book if he doesn't have enough free time
            // to finish reading it.
            //
            //     Print the maximum number of books Valera can read.
            //
            //     Input
            //     The first line contains two integers n and t (1≤n≤105;
            // 1≤t≤109) — the number of books and the number of free minutes Valera's got.
            // The second line contains a sequence of n integers a1,a2,...,an
            // (1≤ai≤104), where number ai shows the number of minutes that the boy
            // needs to read the i-th book.
            //
            //     Output
            //     Print a single integer — the maximum number of books Valera can read.
            //
            //     Examples
            //     inputCopy
            // 4 5
            // 3 1 2 1
            // outputCopy
            // 3
            // inputCopy
            // 3 3
            // 2 2 3
            // outputCopy
            // 1

           
            string[] input = Console.ReadLine().Split();
            int n = int.Parse(input[0]); //number of books
            int t = int.Parse(input[1]); //the number of free minutes valeria got

            int[] books = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            int maxBooks = 0;
            int sumTime = 0; //current sum of book reading times
            int left = 0;
            

            for (int right = 0; right < n; right++)
            {
                sumTime += books[right];

                while (sumTime > t)
                {
                    sumTime -= books[left];
                    left++;
                }

                maxBooks = Math.Max(maxBooks, right - left + 1);
            }

            Console.WriteLine(maxBooks);
            
            // To solve this problem, we can use a two-pointer approach. We'll maintain two pointers, left and right, representing the left and right endpoints of the subarray of books that Valera can read.
            //
            //     Here's the step-by-step algorithm:
            //
            // Read the values of n and t from input.
            //     Read the sequence of n integers representing the time needed to read each book.
            //     Initialize variables: maxBooks to store the maximum number of books Valera can read, sum to store the current sum of book reading times, and left and right as pointers initially set to 0.
            //     Iterate through the books using the right pointer:
            //      Increment right until the sum of book reading times is less than or equal to t.
            //     Update maxBooks if the current number of books (i.e., right - left + 1) is greater than the current maximum.
            //     Increment left to exclude the first book in the subarray.
            //     Decrement the sum by the time needed to read the first book.
        }

    }
}