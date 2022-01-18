using System;

namespace CsharpPracticeDay1
{
  class Program
  {
    static void Main( string[] args )
    {


      //Wrong Substraction
      //input
      string input = Console.ReadLine();
      string[] inputs = input.Split(" ");
      //
      int n = int.Parse(inputs[0]);
      int k = int.Parse(inputs[1]);

      //
      for (int i = 0; i < k; i++)
      {

        if (n % 10 == 0)
        {
          n = n / 10;
        }
        else
        {
          n--;
        }
      }
      Console.WriteLine(n);
    }

  }
}
