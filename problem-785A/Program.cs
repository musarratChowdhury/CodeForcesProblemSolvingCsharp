using System;
using System.Collections;
using System.Text;
using System.Collections.Generic;

namespace ProblemSolving
{
	public class Program
	{
		public static void Main(string[] args)
		{
			//dictionary
			var dictionary = new Dictionary<string, int>()
			{
				{"Tetrahedron",4 },
				{"Cube",6 },
				{"Octahedron",8 },
				{"Dodecahedron",12 },
                {
					"Icosahedron",20
                }
			};


			var words = new List<string>();
			//input
			int N = Convert.ToInt32(Console.ReadLine());

			//
			int result = 0;
			for(int i = 0;i<N;i++)
            {
				words.Add(Console.ReadLine());
            }
			foreach(string word in words)
            {
				if(dictionary.ContainsKey(word))
                {
					result+=dictionary[word];
                }
            }
            Console.WriteLine(result);

		}
	}
}