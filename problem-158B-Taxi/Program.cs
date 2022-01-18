using System;

namespace CsharpPracticeDay1
{
  class Program
  {
    static void Main( string[] args )
    {

      string input = Console.ReadLine();
      int numberOfGroups = int.Parse(input);
      var line = Console.ReadLine();
      var sequenceOfInteger = line.Split(" ");

      int countOf1 = 0, countOf2 = 0, countOf3 = 0, countOf4 = 0;
      int result = 0;

      for (int i = 0; i < numberOfGroups; i++)
      {
        int number = int.Parse(sequenceOfInteger[i]);
        if (number == 1) countOf1++;
        else if (number == 2) countOf2++;
        else if (number == 3) countOf3++;
        else if (number == 4) countOf4++;
      }
      result += countOf4;

      while (countOf1 != 0 && countOf3 != 0)
      {
        countOf3--;
        countOf1--;
        result++;
      }
      if (countOf3 != 0)
      {
        result += countOf3;
        countOf3 = 0;
      }
      result += countOf2 / 2;

      if (countOf2 % 2 != 0)
      {
        if (countOf1 <= 2)
        {
          countOf1 = 0;
          countOf2 = 0;
          result++;
        }
        else
        {
          countOf1 -= 2;
          result++;
          countOf2 = 0;
        }
      }
      if (countOf1 != 0)
      {
        result += countOf1 / 4;
        if (countOf1 % 4 != 0)
        {
          result++;
          countOf1 = 0;
        }
      }
      Console.WriteLine(result);


    }

  }
}
