//
using System;
using System.Collections.Generic;

//implementing the next greater elemetn


namespace AlgorithmLibrary.DataStructure
{
   public class stackAlgo
   {
      public static void PrintNextGreaterElement(int[] arr)
      {
         if(arr.Length<=0)return;
         var stack  = new Stack<int>();
         stack.Push(arr[0]);

         for(int i  = 1;i<arr.Length;i++)
         {
            int next = arr[i];
            if(stack.Count>0)
            {
               int popped = stack.Pop();

               while(popped<next)
               {
                  System.Console.WriteLine(  popped+"-->"+next);
                  if(stack.Count == 0 )
                  {
                     break;
                  }
                  popped = stack.Pop();
               }
               if(popped>next)
               {
                  stack.Push(popped);
               }
            }
            stack.Push(next);
         }

         while(stack.Count>0)
         {
            System.Console.WriteLine(stack.Pop()+"-->"+"-1");
         }

      }
      public static Boolean hasMatchingParenthesis(string s)
      {
         Stack<char> stack = new Stack<char>();

         for(int i  = 0;i<s.Length;i++)
         {
            char current = s[i];

            if(current == '(')
            {
               stack.Push(current);
               continue;
            }
            if(current == ')')
            {
               stack.Pop();
               if(stack.Count>0)
               {
                  stack.Pop();
               }else{
                  return false;
               }
            }
         }
            return stack.Count==0;

      }
   }
}