using System;
using System.Collections.Generic;

namespace problem_443
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputM = Console.ReadLine();
            var inputL = inputM.ToCharArray();
            var charList = new List<char>();
            var uniqCharList = new List<char>();
            foreach(char c in inputL)
            {
                if(char.IsLetter(c))
                {
                    charList.Add(c);
                }
            }
            foreach(var c in charList)
            {
                if(!uniqCharList.Contains(c)){
                    uniqCharList.Add(c);
                }
            }
            System.Console.WriteLine(uniqCharList.Count);

        }
    }
}
