



//
using System;

namespace FoxAndSnake // Note: actual namespace depends on the project name.
{
	internal class Program
	{
		static void Main( string[] args )
		{

			string input = Console.ReadLine();

			int m = Convert.ToInt32(input.Split(" ")[0]);
			int n = Convert.ToInt32(input.Split(" ")[1]);


			var toggle = 0;




			for (int i = 0; i < m; i++)
			{
				for (int j = 0; j < n; j++)
				{
					if (i % 2 != 0)
					{
						if (j == 0 && toggle == 1)
						{
							Console.Write("#");
						}
						else if (j == n - 1 && toggle == 0)
						{
							Console.Write("#");
						}
						else
						{
							Console.Write(".");
						}
					}
					else
					{
						Console.Write("#");

					}

				}
				Console.WriteLine();
				if (i % 2 != 0)
				{
					if (toggle == 0)
					{
						toggle = 1;
					}
					else
					{
						toggle = 0;
					}
				}

			}
		}
	}
}