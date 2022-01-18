using System;

namespace CsharpPracticeDay1
{
  class Program
  {
    static void Main( string[] args )
    {

      ///Bear and Big Brother

      //input
      string input = Console.ReadLine();
      string[] inputs = input.Split(" ");

      //space separated
      int Lw = int.Parse(inputs[0]);
      int Bw = int.Parse(inputs[1]);

      //
      int counter = 0;
      while (Lw <= Bw)
      {


        Lw = Lw * 3;
        Bw = Bw * 2;
        counter++;

      }
      Console.WriteLine(counter);



    }

  }
}
