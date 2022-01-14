namespace AlgorithmLibrary
{
   public partial class Mathematics
   {
      public static int MinOfGivenNumbers(int[] input)
      {
         int min = input[0];
         for(int i = 1;i<input.Length;i++)
         {
            if(min>input[i])
            {
               min = input[i];
            }
         }
         return min;
      }
   }
}