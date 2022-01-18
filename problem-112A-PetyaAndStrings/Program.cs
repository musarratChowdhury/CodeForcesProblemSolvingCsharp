using System;

namespace CsharpPracticeDay1
{
  class Program
  {
    static void Main( string[] args )
    {

      string[] inputs = new string[2];
      for (int i = 0; i < 2; i++)
      {
        inputs[i] = Console.ReadLine();
      }

      int result = string.Compare(inputs[0].ToLower(), inputs[1].ToLower());
      Console.WriteLine(result);





    }

  }
}
