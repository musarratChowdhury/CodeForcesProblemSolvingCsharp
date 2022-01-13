//The queue contains the elements  in the order they were added.
//Elements are inserted at the end and removed from the front.
//FIFO : FIRst in FIRST OUT

//Enqueue : adds and item to the back
//Dequeue : removes an item from the first
//Peek : accesses the item at the front of the queue

//first in first out is useful in algorithms ,
using System;
using System.Collections.Generic;

namespace AlgorithmLibrary.DataStructure
{
   public class queueAlgo{
      public static void PrintBinaryNumbers(int n)
      {
         if(n<=0) return;
         var binaryQueue = new Queue<int>();

         binaryQueue.Enqueue(1);
         for(int i = 0 ;i<n;i++)
         {
            int current = binaryQueue.Dequeue();
            System.Console.WriteLine(current);
            binaryQueue.Enqueue(current*10);
            binaryQueue.Enqueue(current*10+1);
         }
         Console.WriteLine();
      }

   }
}