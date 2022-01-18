using System;

namespace CsharpPracticeDay1
{
  class Program
  {
    static void Main( string[] args )
    {


      //input 
      var input = Console.ReadLine();
      string[] numbers = input.Split(" ");
      //
      int numberOfFriends = int.Parse(numbers[0]);
      int heightOFTheFence = int.Parse(numbers[1]);

      //
      var inputLine2 = Console.ReadLine();
      string[] heights = inputLine2.Split(" ");
      //

      int[] widths = new int[numberOfFriends];
      int sumOfWidths = 0;


      for (int i = 0; i < heights.Length; i++)
      {


        if (int.Parse(heights[i]) > heightOFTheFence)
        {
          widths[i] = 2;
        }
        else
        {
          widths[i] = 1;
        }
        sumOfWidths += widths[i];
      }
      //

      //
      Console.WriteLine(sumOfWidths);



    }

  }
}