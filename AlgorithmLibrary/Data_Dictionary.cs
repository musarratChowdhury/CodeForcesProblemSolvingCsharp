//lets build a frequency calculator
using System.Collections.Generic;
namespace AlgorithmLibrary.DataStructure
{
   public class dictionaryAlgo
   {
      public static void frequencyCalculator(int[] arr)
      {
         var freqDictionary = new Dictionary<int,int>();
         for(int i  = 0;i<arr.Length;i++)
         {
            if(freqDictionary.ContainsKey(arr[i]))
            {
               freqDictionary[arr[i]]++;
            }else{
               freqDictionary.Add(arr[i],1);
            }
         }
         //
         // sortf
          
         //display
         foreach(KeyValuePair<int,int> pair in freqDictionary)
         {
            System.Console.WriteLine(pair.Key+ " : "+pair.Value);
         }
      }
   }
}