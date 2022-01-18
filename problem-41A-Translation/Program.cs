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

			var ReversedInput = ReverseWord(input1);
			if (ReversedInput == input2)
			{
				Console.WriteLine("YES");
			}
			else
			{
				Console.WriteLine("NO");
			}


		}
		public static string ReverseWord( string word )
		{
			var sb = new StringBuilder();
			for (int i = word.Length - 1; i >= 0; i--)
			{
				sb.Append(word[i]);
			}
			return sb.ToString();
		}
	}
}