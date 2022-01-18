


///

using System;
using System.Text;

namespace problemSolving
{
	class Program
	{
		public static void Main( string[] args )
		{
			int[] arr = new int[3];
			//input
			for(int i = 0;i<3;i++)
			{
				arr[i]  = Convert.ToInt32( Console.ReadLine() );	
			}
	

			//step 1;
			var sums = calc(arr[0],arr[1],arr[2]);
			Array.Sort(sums);
			Array.Reverse(sums);
			Console.WriteLine(sums[0]);

		}
		public static int[] calc(int a, int b, int c)
		{
			var sum = 0;
			int[] sums = new int[6];
			//step 1;
			sum = a + b + c;
			sums[0] = sum;
			sum = a + (b * c);
			sums[1] = sum;
			sum = (a * b) + c;
			sums[2] = sum;
			sum = a * b * c;
			sums[3] = sum;
			sum = (a + b) * c;
			sums[4] = sum;	
			sum = a*(b+c);
			sums[5] = sum;
			


			return sums;
		}
	}
}




