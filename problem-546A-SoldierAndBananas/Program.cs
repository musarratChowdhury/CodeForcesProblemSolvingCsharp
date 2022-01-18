using System;

namespace CsharpPracticeDay1
{
  class Program
  {
    static void Main( string[] args )
    {

      ///soldier and bananas

      //input

      //space separated
      string input = Console.ReadLine();
      string[] inputs = input.Split(" ");
      int k = int.Parse(inputs[0]);
      int n = Convert.ToInt32(inputs[1]);
      int w = Convert.ToInt32(inputs[2]);
      //
      int sum = 0;
      for (int i = 1; i <= w; i++)
      {
        sum += (k * i);
      }

      int needToborrow = sum - n;
      if (needToborrow >= 0)
      {
        Console.WriteLine(needToborrow);
      }
      else
      {
        Console.WriteLine(0);
      }



    }

  }
}