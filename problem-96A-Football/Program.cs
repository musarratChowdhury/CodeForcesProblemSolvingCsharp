using System;


namespace CsharpPracticeDay1
{
  class Program
  {
    static void Main( string[] args )
    {




      //input
      string input = Console.ReadLine();
      char[] chars = input.ToCharArray();
      //

      bool a = false;

      int repeatcounter = 1;
      char previousElement;

      for (int i = 1; i < chars.Length; i++)
      {
        previousElement = chars[i - 1];
        if (chars[i] == previousElement && i != chars.Length - 1)
        {
          repeatcounter++;
        }
        else
        {
          if (i == chars.Length - 1 && chars[chars.Length - 1] == previousElement)
          {
            repeatcounter++;
          }

          if (repeatcounter >= 7)
          {
            a = true;
          }
          repeatcounter = 1;
        }
      }
      if (a)
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
