using System;
using System.Text;

namespace CsharpPracticeDay1
{
  class Program
  {
    static void Main( string[] args )
    {



      string input = Console.ReadLine();
      int n = int.Parse(input);

      for (int i = 0; i < n; i++)
      {
        string word = Console.ReadLine();

        if (word.Length > 10)
        {
          StringBuilder sb = new StringBuilder();
          sb.Append(word[0]);
          sb.Append(word.Length - 2);
          sb.Append(word[word.Length - 1]);
          Console.WriteLine(sb.ToString());

        }
        else
        {
          Console.WriteLine(word);
        }
      }




    }


  }
}
