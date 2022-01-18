using System;
using System.Collections.Generic;
using System.Text;

namespace problemSolving
{
	class Magnet
	{

		public int PoleA { get; set; }
		public int PoleB { get; set; }
		public Magnet( int a, int b )
		{
			this.PoleA = a;
			this.PoleB = b;
		}

	}
	class Program
	{


		public static void Main( string[] args )
		{
			var Magnets = new List<Magnet>();
			int numberOfMagnets = Convert.ToInt32(Console.ReadLine());

			int numberofGroups = 1;

			for (int i = 0; i < numberOfMagnets; i++)
			{
				var inputLIne = int.Parse(Console.ReadLine());
				var poleA = inputLIne / 10;
				var poleB = inputLIne % 10;
				var magnet = new Magnet(poleA, poleB);
				Magnets.Add(magnet);




			}
			for (int j = 0; j < numberOfMagnets; j++)
			{
				if (j + 1 != numberOfMagnets)
				{
					if (Magnets[j].PoleB != Magnets[j + 1].PoleA)
					{
						//Console.WriteLine("GRoup formed");
					}
					else
					{
						//Console.WriteLine("Group increased");
						numberofGroups++;
					}
				}
				else
				{
					//Console.WriteLine("number of groups is : "+ numberofGroups);
					Console.WriteLine(numberofGroups);
				}

			}



		}
	}
}
