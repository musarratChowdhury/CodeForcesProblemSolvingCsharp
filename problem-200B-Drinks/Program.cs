using System;
//using System.Collections;


namespace ProblemSolving;

class Program
{
	public static void Main( string[] args )
	{
		double result = 0;
		var inputN = Convert.ToInt32(Console.ReadLine());
		var inputLine = Console.ReadLine().Split(' ');
		foreach (var number in inputLine)
		{
			result += Convert.ToDouble(number);
		}
		Console.WriteLine(result / inputN);

	}
}



