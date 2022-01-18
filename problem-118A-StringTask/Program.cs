using System;
using System.Text;

namespace CsharpPracticeDay1
{
  class Program
  {
    static void Main( string[] args )
    {

      StringBuilder sb = new StringBuilder();

      string input = Console.ReadLine();
      string lowerCaseInput = input.ToLower();
      //Console.WriteLine("fdf");


      for (int i = 0; i < lowerCaseInput.Length; i++)
      {
        if (lowerCaseInput[i] == 'a' || lowerCaseInput[i] == 'o' || lowerCaseInput[i] == 'e' || lowerCaseInput[i] == 'y' || lowerCaseInput[i] == 'i' || lowerCaseInput[i] == 'u')
        {
          //Console.WriteLine("hi");

          continue;
        }
        else
        {
          sb.Append('.');
          sb.Append(lowerCaseInput[i]);
        }
      }
      Console.WriteLine(sb.ToString());


    }

  }
}
