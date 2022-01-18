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
			string input2 = Console.ReadLine();
			int numberOfParticipants = Convert.ToInt32(input1.Split(' ')[0]);
			int kth = Convert.ToInt32(input1.Split(' ')[1]) - 1;
			//Console.WriteLine(kth);
			//
			var scores = input2.Split(' ');
			var valueOfKth = Convert.ToInt32(scores[kth]);
			//Console.WriteLine(valueOfKth);
			//
			int counter = 0;
			for (int i = 0; i < numberOfParticipants; i++)
			{
				int score = Convert.ToInt32(scores[i]);
				if (score >= valueOfKth && score != 0)
				{
					counter++;
					//Console.WriteLine(score);
				}
			}
			Console.WriteLine(counter);



		}
	}
}
