using System;
using System.Text;

namespace CsharpPracticeDay1
{
  class Program
  {
    static void Main( string[] args )
    {



      //input
      string s = Console.ReadLine();
      char[] chars = s.ToCharArray();
      //
      string desiredWord = "hello";
      int count = 0, index = 0;

      for (int i = 0; i < chars.Length; i++)
      {
        if (chars[i] == desiredWord[index])
        {
          count++;
          //if(index<desiredWord.Length)
          index++;

          //Console.WriteLine(chars[i]);
        }
        if (index == 5) break;

      }

      if (count == 5)
      {
        Console.WriteLine("YES");
      }
      else
      {
        Console.WriteLine("NO");
      }


    }

  }
}