
using System;
using static System.Console;
using System.Text;
using System.Linq;
using System.Threading;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

namespace problem
{
  class Program
  {
    static void Main( string[] args )
    {
			//input
			var numberOfTestCases = Convert.ToInt32(ReadLine());
			

			while(numberOfTestCases > 0)
			{
				var testCaseArr = new List<int>();
				var n = Convert.ToInt32(ReadLine());
				var line1 = Console.ReadLine().Split(" ");
				for(int i = 0;i<line1.Length;i++)
				{
					testCaseArr.Add(Convert.ToInt32(line1[i]));
				}

				//Console.WriteLine(testCaseArr[0]);
				//check for sorted arr
				if(CheckArr(testCaseArr))
				{
					Console.WriteLine("YES");
				}
				else
				{
					Console.WriteLine("NO");
				}
				numberOfTestCases--;
			}



			//Read();
			//necessary variables


			//solution



		}
		static bool CheckArr(List<int> arr)
		{
			arr.Sort();
			for(int i = 0;i< arr.Count;i++)
			{
				if(i != arr.Count - 1&&arr[i+1]-arr[i]>1)
				{
					return false;
				}
			}
			return true;
		}
  }
}
