using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DataStructures_and_Algorithms.Priority_Queues_and_Hashing
{
    //What is priorityQueue in C# ?
    // In C#, the PriorityQueue class is present in the System.Collections.
    // Generic namespace. It stores elements according to their priority.
    // Elements with greater priority are removed from the queue before those with lesser priority.
    // It can be implemented using SortedList or SortedDictionary.
    //Elements are inserted with an associated priority.
    //Elements are removed based on their priority, lower numerical priority values are dequeued first(since PriorityQueue in C# is a min-heap).
    //The queue ensures that the elements with the lowest priority value are dequeued first.
    //Elements are sorted internally according to their priority values.
    public class PriorityQueue
    {
       public void Work_PriorityQueue()
        {
            PriorityQueue<int, int> pq = new PriorityQueue<int, int>();

            // Enqueue
            pq.Enqueue(30, 30);
            pq.Enqueue(10, 10);
            pq.Enqueue(50, 50);
            pq.Enqueue(20, 20);

            Console.WriteLine("Count: " + pq.Count); // 

           
            Console.WriteLine("Peek: " + pq.Peek());

            
            Console.WriteLine("Dequeued: " + pq.Dequeue()); //Removes and returns the element with the lowest priority value.
            Console.WriteLine("Dequeued: " + pq.Dequeue()); //Returns the next element (lowest priority) without removing it.

            Console.WriteLine("Count After Dequeue: " + pq.Count);

          
            Console.WriteLine("\nRemaining Elements:");

            while (pq.Count > 0)
            {
                Console.WriteLine(pq.Dequeue());
            }

        }


    }
}
