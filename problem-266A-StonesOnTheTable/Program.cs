
using System;

namespace CsharpPracticeDay1
{
  class Program
  {
    static void Main( string[] args )
    {

      //int count = 0;
      int repeat = 0;
      //taking input
      string numberOfStones = Console.ReadLine();
      int n = Convert.ToInt32(numberOfStones);
      string colorSequence = Console.ReadLine();

      //string[] arr = new string[n];
      for (int i = 0; i < colorSequence.Length; i++)
      {
        if (i != 0)
        {
          if (colorSequence[i] == colorSequence[i - 1])
          {
            repeat++;

          }
        }
      }

      Console.WriteLine(repeat);


    }

  }
}