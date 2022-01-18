using System;


namespace CsharpProblemSolving
{
  class Program
  {

    static void Main( string[] args )
    {

      int[,] input = new int[5, 5];

      int result = 0;

      for (int i = 0; i < 5; i++)
      {
        string line = Console.ReadLine();
        string[] arr = line.Split(' ');
        for (int j = 0; j < arr.Length; j++)
        {
          input[i, j] = Convert.ToInt32(arr[j]);
          if (input[i, j] == 1)
          {
            result = Math.Abs(i - 2) + Math.Abs(j - 2);
          }
        }
      }
      Console.WriteLine(result);


    }
  }
}