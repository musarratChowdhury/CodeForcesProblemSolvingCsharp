using System;
using System.Collections.Generic;

namespace problem_25A
{
    class Program
    {
        static void Main(string[] args)
        {
            int n  = Convert.ToInt32(Console.ReadLine());
            var inputL = Console.ReadLine().Split(" ");
            var numberList  = new List<int>();

            int subcount = 3;
            int evenCOunt = 0;
            int oddCount = 0;

            int result = 0;

            foreach(var i in inputL)
            {
                numberList.Add(Convert.ToInt32(i));
                if(subcount>=0)
                {
                    if(Convert.ToInt32(i)%2==0)
                    {
                        evenCOunt++;
                        subcount--;
                    }else{
                        oddCount++;
                        subcount--;
                    }
                }
            }
            if(evenCOunt>oddCount)
            {
                // System.Console.WriteLine("getting the odd index");
                    for(int i = 0;i<numberList.Count;i++)
                    {
                        if(numberList[i]%2!=0)
                        {
                            result = i;
                            break;
                        }
                    }
            }else{
                for(int i = 0;i<numberList.Count;i++)
                    {
                        if(numberList[i]%2==0)
                        {
                            result = i;
                            break;
                        }
                    }
            }

            System.Console.WriteLine( result+1);
        }
    }
}
