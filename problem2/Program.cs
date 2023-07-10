using System;
using System.Collections.Generic;

namespace problem2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Problem:
            // Given a string, write a function to generate all possible permutations of the characters in the string.
            //
            //     For example:
            // Input: "abc"
            // Output: ["abc", "acb", "bac", "bca", "cab", "cba"]
            // To solve this problem, you can use a recursive approach known as backtracking
            
            string input = "abc";
            var permutations = GeneratePermutations(input);
        
            Console.WriteLine("All possible permutations:");
            foreach (string permutation in permutations)
            {
                Console.WriteLine(permutation);
            }
        }

        static List<string> GeneratePermutations(string input)
        {
            List<string> permutations = new List<string>();
            Permute(input.ToCharArray(), 0, permutations);
            return permutations;
        }
        //[a,b,c]
        static void Permute(char[] chars, int currentIndex, List<string> permutations)
        {
             // base case
             //currentindex == 2
            if (currentIndex == chars.Length - 1)
            {
                permutations.Add(new string(chars));
                return;
            }
            
            //currentIndex == 0, 
            for (int i = currentIndex; i < chars.Length; i++)
            {
                Swap(chars, currentIndex, i);//[b,a,c]
                Permute(chars, currentIndex + 1, permutations);
                Swap(chars, currentIndex, i); // backtrack (restore the original order)
            }
        }

        static void Swap(char[] chars, int i, int j)
        {
            (chars[i], chars[j]) = (chars[j], chars[i]);
        }
    }
}