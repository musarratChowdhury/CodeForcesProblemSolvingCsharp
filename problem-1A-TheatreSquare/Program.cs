using System;

namespace CsharpPracticeDay1
{
  class Program
  {
    static void Main( string[] args )
    {


      string input = Console.ReadLine();
      string[] numbers = input.Split(" ");
      ulong n = ulong.Parse(numbers[0]);
      ulong m = ulong.Parse(numbers[1]);
      ulong a = ulong.Parse(numbers[2]);
      //
      //solve
      ulong flagStonesToCoverARow = n / a;
      if (n % a > 0)
        flagStonesToCoverARow++;

      ulong flagStonesToCoverCol = m / a;
      if (m % a > 0) flagStonesToCoverCol++;
      ulong totalFlagStonesNeeded = flagStonesToCoverCol * flagStonesToCoverARow;
      Console.WriteLine(totalFlagStonesNeeded);





    }

  }
}
