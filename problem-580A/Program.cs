using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;



//

// Kefa and First Steps
//
namespace problem_580A
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var inputN = Convert.ToInt32(Console.ReadLine());
            var inputL = Console.ReadLine().Split( ' ');
            int count = 1;
            var listy = new List<int>();
            int previousValue =  Convert.ToInt32(inputL[0]);
            if(inputN==1)
            {
                System.Console.WriteLine(inputN);
                return;
            }
            for(int i = 1;i<inputN;i++)
            {
                int presentvalue = Convert.ToInt32(inputL[i]);
                if(presentvalue>=previousValue)
                {
                    count++;
                    previousValue = presentvalue;
                    listy.Add(count);
                }else{
                    listy.Add(count);
                    count = 1;
                    previousValue = presentvalue;
                }


            }
            listy.Sort();
            listy.Reverse();
            System.Console.WriteLine(listy[0]);
        }
    }
}
