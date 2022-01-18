using System;
using System.Text;

namespace CsharpPracticeDay1
{
  class Program
  {
    static void Main( string[] args )
    {



      string input = Console.ReadLine();

      //
      StringBuilder stringBuilder = new StringBuilder();
      //string[] arr = new string[input.Length];

      for (int i = 0; i < input.Length; i++)
      {
        if (stringBuilder.ToString().Contains(input[i]))
        {
          continue;
        }
        else
        {
          stringBuilder.Append(input[i]);
        }
      }
      if (stringBuilder.ToString().Length % 2 == 0)
      {
        Console.WriteLine("CHAT WITH HER!");
      }
      else
      {
        Console.WriteLine("IGNORE HIM!");
      }


    }

  }
}
