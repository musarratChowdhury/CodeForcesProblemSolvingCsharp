using System;

namespace CsharpPracticeDay1
{
  class Program
  {
    static void Main( string[] args )
    {

      //input
      string line1 = Console.ReadLine();
      var inputs = line1.Split(" ");
      int n = int.Parse(inputs[0]);
      int t = int.Parse(inputs[1]);

      string initialArrangement = Console.ReadLine();
      char[] arrangement = initialArrangement.ToCharArray();

      //

      char temp;
      for (int j = 0; j < t; j++)
      {
        for (int i = 0; i < n; i++)
        {
          if (i != n - 1 && arrangement[i] == 'B' && arrangement[i + 1] == 'G')
          {
            temp = arrangement[i];

            arrangement[i] = arrangement[i + 1];
            arrangement[i + 1] = temp;
            i++;

          }

        }
      }

      //Array.ForEach(arrangement, Console.WriteLine);
      Console.WriteLine(new String(arrangement));







    }

  }
}