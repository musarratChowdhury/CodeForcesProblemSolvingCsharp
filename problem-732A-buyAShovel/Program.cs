
using System;
using System.Text;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace problem
{
  class Program
  {
    static void Main( string[] args )
    {
      //input
      var line1 = Console.ReadLine().Split(" ");
      int k = Convert.ToInt32(line1[0]);
      int r = Convert.ToInt32(line1[1]);
      //var line2 = Console.ReadLine().Split(" ");

        for(int i = 1;i<int.MaxValue;i++)
				{
          int multiple = k * i;
          if(multiple%10==0)
					{
            Console.WriteLine(i);
            break;
					}
          if(multiple%10==r)
					{
            Console.WriteLine(i);
            break;
					}
				}
			
      //necessary variables


      //solution



    }
  }
}