using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var result = 0;
            int n = Convert.ToInt32(Console.ReadLine());    
            for(int i = 0; i < n; i++)
            {
                int number  = Convert.ToInt32(Console.ReadLine());
                if(number<3)
                {
                    Console.WriteLine(0);
                }else if(number==3)
                {
                    Console.WriteLine(1);
                }else if(number%2==0)
                {
                     result = number / 2 - 1;
                    Console.WriteLine(result);
                }else if(number%2!=0)
                {
                    result = number / 2;
                    Console.WriteLine(result);
                }
            }
 

        }
    }
}
