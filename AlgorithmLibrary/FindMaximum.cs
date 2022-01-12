using System;


namespace AlgorithmLibrary
{
   public partial class Mathematics
   {
      public static int FindMaximum(int a, int b ,int c)
      {
         int max = a;
         if(b>max)
         {
            max = b;
         }
         if(c>max)
         {
            max = c;
         }
         return max;
      }
   }
}