using System;
using System.Collections.Generic;

namespace problem_520A
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberofLetters = Convert.ToInt32(Console.ReadLine());
            var word = Console.ReadLine().ToLower();

            ///
            if(numberofLetters<26)
            {
                System.Console.WriteLine("NO");

                return;
            }else
            {
                //find out the array of uniq letters and then mesure length again
                var recieveArr = GiveAlltheuniqChars(word);
                if(recieveArr.Count==26)
                {
                    System.Console.WriteLine("YES");

                }else
                {
                    System.Console.WriteLine("NO");
                    return;
                }
            }
            
        }
        static List<char> GiveAlltheuniqChars(string input)
        {
            var listofChars =new List<char>();
            var charArr = input.ToCharArray();

            foreach(char c in charArr)
            {
                if(!listofChars.Contains(c))
                {
                    listofChars.Add(c);
                }
            }
          
           
            return listofChars;

        }
    }
}
