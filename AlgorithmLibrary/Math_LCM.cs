//
// We know, 
// LCM(a, b)=frac{a*b}/{gcd(a, b)}            
// The above relation only holds for two numbers, 
// Initialize ans = arr[0].
// Iterate over all the elements of the array i.e. from i = 1 to i = n-1 
// At the ith iteration ans = LCM(arr[0], arr[1], …….., arr[i-1]). This can be done easily as LCM(arr[0], arr[1], …., arr[i]) = LCM(ans, arr[i]). Thus at i’th iteration we just have to do ans = LCM(ans, arr[i]) = ans x arr[i] / gcd(ans, arr[i]) 
//

//n
namespace AlgorithmLibrary
{
   public partial class Mathematics
   {
      public static int LCMOfTwoNumbers(int a,int b)
      {
         int result = 0;
         int multiplied = a*b;
         int GcmOfThoseNumbers = GCDofTwoNumbers(a,b);
         result = multiplied/GcmOfThoseNumbers;


         return result;
      }
      public static int LCMofAnArrayOfNumbers(int[] input)
      {
         //we can do lcm of two numbers by pairs
         int result = input[0];
         for(int i = 1;i<input.Length;i++)
         {
            result = LCMOfTwoNumbers(input[i],result);
         }
         return result;
      }
   }
}