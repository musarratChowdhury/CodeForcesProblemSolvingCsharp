using System;
using System.Collections.Generic;

namespace problem_1328A
{
    class Program
    {
        static void Main(string[] args)
        {
            var dictionary = new List<(int,int)>();
            
            var t = Convert.ToInt32(Console.ReadLine());
            for(int i = 0;i<t;i++)
            {
                var line = Console.ReadLine().Split(' ');
                
                    (int a ,int b ) a_b = (Convert.ToInt32(line[0]),Convert.ToInt32(line[1]));
                   

                
                dictionary.Add(a_b);
            }
            var mydictionary = dictionary.ToArray();
            for(int i =0;i<mydictionary.Length;i++)
            {
               
                Console.WriteLine(DiffFromNextMultiPleOfaNumber(mydictionary[i].Item1,mydictionary[i].Item2));
            }

        }
        static int DiffFromNextMultiPleOfaNumber(int a,int b)
        {
            //divide by 5
            if(a%b!=0)
            {
                int x = a/b;
            int y = x+1;
            int multiple = y*b;
            return (multiple - a);
            }else{
                return 0;
            }
            

        }
    }
}
