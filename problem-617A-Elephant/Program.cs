using System;

namespace CsharpPracticeDay1
{
  class Program
  {
    static void Main( string[] args )
    {



      //input 
      int x = int.Parse(Console.ReadLine());
      //
      int reqSteps = 0;

      //
      while (x != 0)
      {
        if (x >= 5)
        {
          reqSteps += (x / 5);
          x = x % 5;
        }
        else
        {
          if (x % 4 == 0)
          {
            reqSteps++;
            x = x % 4;
          }
          else if (x % 3 == 0)
          {
            reqSteps++;
            x = x % 3;
          }
          else if (x % 2 == 0)
          {
            reqSteps++;
            x = x % 2;
          }
          else if (x % 1 == 0)
          {
            reqSteps++;
            x = x % 1;
          }
        }
      }


      Console.WriteLine(reqSteps);


    }

  }
}