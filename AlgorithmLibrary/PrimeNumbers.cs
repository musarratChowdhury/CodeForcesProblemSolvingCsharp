
// Now, according to formal definition, a number ‘n’ is prime if it is not divisible by any number other than 1 and n. In other words a number is prime if it is not divisible by any number from 2 to n-1.
//
using System;
using System.Collections;
namespace AlgorithmLibrary
{
   public partial class Mathematics
   {
      public class PrimeNumbers
      {
         public static void PrintAllPrimesTill(int n)
         {
               for(int i = 1;i<=n;i++)
               {
                  if(isPrime(i))
                  {
                     Console.WriteLine(i+" ");
                  }
               }
         }
         public static int[] GetAllPrimesTill(int n)
         {
            var list = new ArrayList();
            for(int i = 1;i<=n;i++)
               {
                  if(isPrime(i))
                  {
                     list.Add(i);
                  }
               }
            return (int[])list.ToArray(typeof(int));

         }
         public static bool isPrime(int n)
         {
            if(n==1||n==0) return false;
            //
            for(int i = 2;i<=n/2;i++)
            {
               if(n%i==0)
               return false;
            }

            return true;
         }
      }
   }
}