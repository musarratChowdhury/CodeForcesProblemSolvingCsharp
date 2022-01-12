using System;
using System.Collections.Generic;

namespace problem_228A
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputL = Console.ReadLine().Split(' ');
            var uniqueShoes = new List<string>();
            int needToBuy = 0;
            for(int i = 0;i<4;i++)
            {
                if(!uniqueShoes.Contains(inputL[i]))
                {
                        uniqueShoes.Add(inputL[i]);
                }else{
                    needToBuy++;
                }
            }
            System.Console.WriteLine(needToBuy);
        }
    }
}
