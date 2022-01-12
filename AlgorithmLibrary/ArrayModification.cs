
namespace AlgorithmLibrary
{
   public partial class ArrayAlgo{
        public static int[] Reverse(int[] inputArr)
      {
         
         int temp = 0;
         for(int i =0;i<inputArr.Length/2;i++)
         {
            temp = inputArr[i];
            inputArr[i] = inputArr[inputArr.Length-1-i];
            inputArr[inputArr.Length-1-i] = temp;
         }
         return inputArr;
      }
      public static int[] RotateArrayLeft(int[] inputArr)
      {
         int temp = inputArr[0];
         for(int i = 0;i<inputArr.Length-1;i++)
         {
            inputArr[i] = inputArr[i+1];
         }
         inputArr[inputArr.Length-1]  = temp;
         return inputArr;
      }
      public static int[] RotateArrayRight(int[] inputArr)
      {
            int temp = inputArr[inputArr.Length-1];
            for(int i = inputArr.Length-1;i>0;i--)
            {
               inputArr[i] = inputArr[i-1];
            }
            inputArr[0] = temp;
            return inputArr;
      }
   }
}