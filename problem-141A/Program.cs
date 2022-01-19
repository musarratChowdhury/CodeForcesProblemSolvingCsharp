


using System;
using System.Collections.Generic;

namespace ProblemSolving
{
    class Program
    {
        public static void Main (string[] args)
        {
            //input
            var inputLine1 = Console.ReadLine();
            var inputLine2 = Console.ReadLine();
            var inputLine3 = Console.ReadLine();
            //list
            var namesLetters = new List<char> ();
            var allLetters = new List<char> ();
            
            
            foreach(char c in inputLine1)
            {
                namesLetters.Add (c);
            }
            foreach (char c in inputLine2)
            {
                namesLetters.Add(c);
            }
            foreach (char c in inputLine3)
            {
                 allLetters.Add(c);
            }
            if (namesLetters.Count > allLetters.Count)
            {
                Console.WriteLine("NO");
                return;
            }

            foreach (char c in namesLetters)
            {
                if(allLetters.Contains(c))
                {
                    allLetters.Remove(c);   
                }
            }
            if(allLetters.Count > 0)
            {
                Console.WriteLine("NO");
            }
            else
            {
                Console.WriteLine("YES");
            }
        }
    }

}