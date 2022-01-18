using System;

class Exercise11

{

  static void Main()

  {

    int n = Convert.ToInt32(Console.ReadLine());

    int p = 0;

    for (int i = 0; i < n; i++)

    {
      string b = Console.ReadLine();


      if (b.Contains('-'))

      {
        p--;
      }

      else

      {
        p++;
      }
    }
    Console.WriteLine(p);

  }

}
