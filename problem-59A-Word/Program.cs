using System;

namespace CsharpPracticeDay1
{
  class Program
  {
    static void Main( string[] args )
    {



      string s = Console.ReadLine();
      char[] chars = s.ToCharArray();
      int countOfUpperCase = 0;
      int countOfLowerCase = 0;
      int totalChars = chars.Length;


      foreach (var c in chars)
      {
        if (Char.IsUpper(c))
        {
          countOfUpperCase++;
        }
      }
      countOfLowerCase = totalChars - countOfUpperCase;

      if (countOfLowerCase < countOfUpperCase)
      {
        Console.WriteLine(s.ToUpper());
      }
      else
      {
        Console.WriteLine(s.ToLower());
      }






    }

  }
}
