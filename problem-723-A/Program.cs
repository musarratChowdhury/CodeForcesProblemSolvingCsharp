namespace problem_723_A
{
	internal class Program
	{
		static void Main( string[] args )
		{
			//Console.WriteLine("Hello, World!");
			//input
			var line = Console.ReadLine().Split(" ");
			List<int> cords = new();

			foreach (var i in line)
			{
				cords.Add(Convert.ToInt32(i));
			}

			cords.Sort();
			int max = cords[2];
			int middle = cords[1];
			int min = cords[0];
			int midpoint;
			int A, B, C;


			//if (Math.Abs(middle - max) > Math.Abs(middle - min))
			//{
				A = Math.Abs(middle - min);
				B = 0;
				C = Math.Abs(middle - max);
				Console.WriteLine(A + B + C);

			//}
			//else
			//{
   //      //
			//}

			//int dmaxmin = max - min;
			//double avgmaxmin = dmaxmin / 2;
			//double probableMiddlePoint = min + avgmaxmin;

			//if(probableMiddlePoint == (int)probableMiddlePoint)
			//{
			//	A = Math.Abs(middle - (int)probableMiddlePoint);
			//	B = Math.Abs(max - (int)probableMiddlePoint);
			//	C = Math.Abs(min - (int)probableMiddlePoint);
			//	Console.WriteLine(A + B + C);
			//	return;
			//}
			//else
			//{

			//	if((middle - (int)probableMiddlePoint)>(middle-Math.Ceiling(probableMiddlePoint)))
			//	{
			//		midpoint = (int)probableMiddlePoint;
			//	}else
			//	{
			//		midpoint = (int)Math.Ceiling(probableMiddlePoint);
			//	}
			//	A = Math.Abs(middle - midpoint);
			//	B = Math.Abs(max - midpoint);
			//	C = Math.Abs(min - midpoint);
			//	Console.WriteLine(A + B + C);
			//	return;
			//}

		}
	}
}