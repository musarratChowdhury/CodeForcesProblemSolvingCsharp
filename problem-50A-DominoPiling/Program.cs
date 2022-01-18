using System;
using System.Text;

namespace problemSolving
{
	class Program
	{
		public static void Main( string[] args )
		{
			//input
			string input1 = Console.ReadLine();
			int row = Convert.ToInt32(input1.Split(' ')[0]);
			int col = Convert.ToInt32(input1.Split(' ')[1]);
			int horizontalPlacement = 0;
			int verticalPlacement = 0;
			int numberOfDominoesNeeded = 0;
			if (row * col >= 2)
			{

				if (col >= 1)
				{
					if (col == 1)
					{
						verticalPlacement = row / 2;
						numberOfDominoesNeeded += verticalPlacement * col;
					}
					else
					{
						horizontalPlacement += col / 2;
						numberOfDominoesNeeded += horizontalPlacement * row;
						if (col % 2 != 0 && row >= 2)
						{
							verticalPlacement += row / 2;
							numberOfDominoesNeeded += verticalPlacement;
						}
					}
				}

				Console.WriteLine(numberOfDominoesNeeded);


			}
			else
			{
				Console.WriteLine(numberOfDominoesNeeded);
			}
		}
	}
}
