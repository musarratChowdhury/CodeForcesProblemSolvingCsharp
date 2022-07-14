using System.Collections;
using System.Collections.Generic;
using System.Linq;
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
      public static int[] MergeTwoArrays(int[] a,int[] b,bool uniqueList)
      {
            var arrayList = new ArrayList();
            var uniqArrList = new ArrayList();
            foreach(var item in a)
            {
               arrayList.Add(item);
            }
            foreach(var item in b)
            {
               arrayList.Add(item);
            }
            if(!uniqueList)
            return (int[])arrayList.ToArray(typeof(int));
            else{
               foreach(var item in arrayList)
               {
                  if(!uniqArrList.Contains(item))
                  {
                     uniqArrList.Add(item);
                  }
               }
               return (int[])uniqArrList.ToArray(typeof(int));
            }
      }
        public static bool ContainsDuplicate(int[] nums)
        {
            var uniques = nums.Distinct();

            if(uniques.Count()==nums.Length)
                return false;

            return true;
        }
   }
}