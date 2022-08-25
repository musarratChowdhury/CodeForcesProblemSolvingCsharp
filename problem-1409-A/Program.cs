
using System;
using static System.Console;
using System.Text;
using System.Linq;
using System.Threading;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

namespace problem
{
  class Program
  {
    static void Main( string[] args )
    {
			//input
			var testCases = Convert.ToInt32(ReadLine());

			while(testCases>0)
			{
				testCases--;
				var line = Console.ReadLine().Split(" ");
				long a = Convert.ToInt64(line[0]);
				long b = Convert.ToInt64(line[1]);

				long steps;

				//if(a>b)
				//{
				//	//use reduction
					var diff = Math.Abs(a - b);
					 steps = diff / 10;
					if(diff % 10 != 0)
					{
						steps++;
					}
				Console.WriteLine(steps);
				
				

			}
			//int n = Convert.ToInt32(line1?[0]);
			//int m = Convert.ToInt32(line1?[1]);
			//var line2 = ReadLine()?.Split(" ");



			//Read();
			//necessary variables


			//solution



		}
  }
}