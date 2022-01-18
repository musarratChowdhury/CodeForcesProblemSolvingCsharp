using System;
using System.Collections;

namespace CsharpPracticeDay1
{
  class Program
  {
    static void Main( string[] args )
    {

      //input
      int numberOfStops = Convert.ToInt32(Console.ReadLine());
      int totalNumberOfPassengersatAtime = 0;
      ArrayList arrayList = new ArrayList();
      while (numberOfStops > 0)
      {
        string input = Console.ReadLine();
        string[] inputs = input.Split(" ");

        int passengersExit = int.Parse(inputs[0]);
        int passengersEnter = int.Parse(inputs[1]);

        totalNumberOfPassengersatAtime -= passengersExit;
        totalNumberOfPassengersatAtime += passengersEnter;

        arrayList.Add(totalNumberOfPassengersatAtime);




        numberOfStops--;
      }

      arrayList.Sort();

      object[] arr = arrayList.ToArray();
      Console.WriteLine(arr[arr.Length - 1]);




    }

  }
}
