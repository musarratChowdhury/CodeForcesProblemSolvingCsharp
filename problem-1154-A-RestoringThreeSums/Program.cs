
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
			var line1 = ReadLine()?.Split(" ");
			int n = Convert.ToInt32(line1?[0]);
			int m = Convert.ToInt32(line1?[1]);
			int o = Convert.ToInt32(line1?[2]);
			int p = Convert.ToInt32(line1?[3]);

			var numbers = new List<int>();

			for(int i = 0;i<line1.Length;i++)
			{
				numbers.Add(Convert.ToInt32(line1[i]));
			}
			numbers.Sort();
			var additionOfThreeNumbers = numbers[3];
			var anotherAddition = numbers[0];

			var number1 = additionOfThreeNumbers-numbers[1];
			var number2 = anotherAddition - number1;
			var number3 = numbers[1] - number2;

			Console.WriteLine($"{number1} {number2} {number3}");
			//Console.WriteLine(additionOfThreeNumbers);





			//Read();
			//necessary variables


			//solution



		}
	}
}