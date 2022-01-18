using System;
using System.Collections;
using System.Text;
using System.Collections.Generic;

namespace ProblemSolving
{
	public class Program
	{
		public static void Main( string[] args )
		{
			//input
			//var line1 = Console.ReadLine();
			///input a number
			var n = Console.ReadLine();
			char[] chars = n.ToCharArray();

			var luckyDigitCount = 0;
			for (int i = 0; i < chars.Length; i++)
			{
				if (chars[i] is '4' || chars[i] is '7')
				{
					luckyDigitCount++;
				}
			}
			if (luckyDigitCount != 7 && luckyDigitCount != 4)
				Console.WriteLine("NO");
			else
				Console.WriteLine("YES");



		}
	}
}
