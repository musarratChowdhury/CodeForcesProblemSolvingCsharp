using System;
using System.Collections.Generic;
using System.Collections;


namespace AlgorithmLibrary
{
   public partial class Mathematics
   {
      public static bool FindLargestMultipleOf3(int[] input)
      {
            var result = new List<int>();
            Array.Sort(input);
            int sumOfDigits = 0;
            var queue0 = new Queue<int>();
            var queue1 = new Queue<int>();
            var queue2 = new Queue<int>();

            foreach(int i in input)
            {
               sumOfDigits+=i;
               if(i%3==0)
               {
                  queue0.Enqueue(i);
               }else if(i%3==1)
               {
                  queue1.Enqueue(i);
               }else if(i%3==2)
               {
                  queue2.Enqueue(i);
               }
            }

            if(sumOfDigits%3==1)
            {
               if(queue1.Count!=0)
                  queue1.Dequeue();
               else 
               {
                   if(queue2.Count!=0)
                   {
                      queue2.Dequeue();
                   }else
                   return false;
                   if(queue2.Count!=0)
                   {
                      queue2.Dequeue();
                   }else
                   return false;
               }   
             
            }
            else if(sumOfDigits%3==2)
            {
                  if(queue2.Count!=0)
                  queue2.Dequeue();
               else 
               {
                   if(queue1.Count!=0)
                   {
                      queue1.Dequeue();
                   }else
                   return false;
                   if(queue1.Count!=0)
                   {
                      queue1.Dequeue();
                   }else
                   return false;
               }  
            }

            //now lets dequeue into the list to create the result

            while(queue0.Count!=0)
            {
               result.Add(queue0.Dequeue());
            }
            while(queue1.Count!=0)
            {
               result.Add(queue1.Dequeue());
            }
            while(queue2.Count!=0)
            {
               result.Add(queue2.Dequeue());
            }

            result.Sort();
            result.Reverse();

            foreach(int i in result)
            {
               System.Console.Write(i);
            }

            return true;

      }
   }
}