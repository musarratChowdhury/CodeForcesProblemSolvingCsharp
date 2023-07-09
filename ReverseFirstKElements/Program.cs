using System;
using System.Collections.Generic;

namespace ReverseFirstKElements
{
     static class Program
    {
        public static void Main(string[] args)
        {
            var queue = new Queue<int>();
                queue.Enqueue(10);
                queue.Enqueue(20);
                queue.Enqueue(30);
                queue.Enqueue(40);
                queue.Enqueue(50);
                
            ReverseFirstKElements(queue, 3);

            PrintQueue(queue);
        }
        
        static void PrintQueue(Queue<int> queue)
        {
            foreach (int element in queue)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
        }
        
        static void ReverseFirstKElements(Queue<int> queue, int K)
        {
            if (queue.Count == 0 || K <= 0 || K > queue.Count)
            {
                return;
            }

            Queue<int> auxQueue = new Queue<int>();

            // Step 2: Dequeue the first K elements and enqueue them into auxQueue
            for (int i = 0; i < K; i++)
            {
                int element = queue.Dequeue();
                auxQueue.Enqueue(element);
            }

            Console.WriteLine("\nAfter Step 2:");
            Console.WriteLine("Original Queue:");
            PrintQueue(queue);
            Console.WriteLine("Auxiliary Queue:");
            PrintQueue(auxQueue);

            // Step 3: Reverse the elements in auxQueue
            ReverseQueue(auxQueue);

            Console.WriteLine("\nAfter Step 3:");
            Console.WriteLine("Original Queue:");
            PrintQueue(queue);
            Console.WriteLine("Reversed Auxiliary Queue:");
            PrintQueue(auxQueue);

            // Step 4: Enqueue the reversed elements back into the original queue
            while (auxQueue.Count > 0)
            {
                int element = auxQueue.Dequeue();
                queue.Enqueue(element);
            }

            Console.WriteLine("\nAfter Step 4:");
            Console.WriteLine("Reversed Queue:");
            PrintQueue(queue);
            Console.WriteLine("Auxiliary Queue (empty):");
            PrintQueue(auxQueue);

            // Step 5: Dequeue the remaining elements from the original queue and enqueue them back
            for (int i = 0; i < queue.Count - K; i++)
            {
                int element = queue.Dequeue();
                queue.Enqueue(element);
            }

            Console.WriteLine("\nAfter Step 5:");
            Console.WriteLine("Final Reversed Queue:");
            PrintQueue(queue);
        }
        
        static void ReverseQueue(Queue<int> queue)
        {
            Stack<int> stack = new Stack<int>();

            while (queue.Count > 0)
            {
                stack.Push(queue.Dequeue());
            }

            while (stack.Count > 0)
            {
                queue.Enqueue(stack.Pop());
            }
        }
    }
}