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
			var Xvalues = new List<int>();
			var Yvalues = new List<int>();
			var Zvalues = new List<int>();
			//
			var sumOfX = 0;
			var sumOfY = 0;
			var sumOfZ = 0;
			//input
			int n = Convert.ToInt32(Console.ReadLine());
			for (int i = 0; i < n; i++)
			{
				var line = Console.ReadLine();

				string[] vectors = line.Split(' ');
				//
				Xvalues.Add(Convert.ToInt32(vectors[0]));
				Yvalues.Add(Convert.ToInt32(vectors[1]));
				Zvalues.Add(Convert.ToInt32(vectors[2]));
			}
			for (int i = 0; i < n; i++)
			{
				sumOfX += Xvalues[i];
				sumOfY += Yvalues[i];
				sumOfZ += Zvalues[i];
			}
			if (sumOfX == 0 && sumOfY == 0 && sumOfZ == 0)
			{
				Console.WriteLine("YES");
			}
			else
			{
				Console.WriteLine("NO");
			}

		}
	}
}