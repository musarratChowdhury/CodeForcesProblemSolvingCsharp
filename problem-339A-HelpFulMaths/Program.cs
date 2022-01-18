using System;
using System.Text;

namespace CsharpPracticeDay1
{
  class Program
  {
    static void Main( string[] args )
    {
      StringBuilder sb = new StringBuilder();
      string input = Console.ReadLine();
      string[] strArr = input.Split('+');

      Array.Sort(strArr);
      for (int i = 0; i < strArr.Length; i++)
      {
        sb.Append(strArr[i]);
        if (i != strArr.Length - 1)
          sb.Append('+');
      }

      Console.WriteLine(sb.ToString());

    }
  }
}
