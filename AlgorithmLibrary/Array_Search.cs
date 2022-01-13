using System;


namespace AlgorithmLibrary
{
      public  enum Conditions{greater,smaller,equal};

  public partial class ArrayAlgo
   {
      public static int? LinearSearch(int[] input, int n)
      {
         foreach(int  current in input)
         {
            if(current==n)
            return n;
         }
         return null;
      }
      public static int? BinarySearch(int[] input,int n)
      {
         int min = 0;
         int max = input.Length-1;
         while(min<=max)
         {
            int mid = (min+max)/2;
            if(n==input[mid])
            {
               return n;
            }
            else if(n<input[mid])
            {
               max = mid-1;
            }else{
               min = mid+1;
            }
         }
         return null;
      }
    

      public static int[] FindAll(int[] input,int n,Conditions cond)
      {
         int[] items = new int[0];
         switch (cond)
         {
               case Conditions.greater:
                  items = Array.FindAll(input,x=>x>n);
               break;
               case Conditions.smaller:
               
            items =  Array.FindAll(input,x=>x<n);
            break;
            case Conditions.equal:
            items = Array.FindAll(input,x=>x==n);
            break;
             
         }
         return items;
        
      }
   }
}