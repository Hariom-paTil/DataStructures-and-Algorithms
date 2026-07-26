using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures_and_Algorithms.Queue
{

    // What Is Queue?
    // Queue is a linear data structure that follows the First In First Out (FIFO) principle.
    // It means that the first element added to the queue will be the first one to be removed.
    // Think of it like a line of people waiting for a service; the first person in line is served first.
    // In a queue, there are two main operations:
    // Enqueue: This operation adds an element to the rear of the queue.
    // Dequeue: This operation removes the front element from the queue.
    // Other operations include:
    // Peek: This operation returns the front element of the queue without removing it.
    public class Queue_Implement
    {
        public int[] queue;
        public int front = 0;
        public int rear = 0;
        public int size = 0;

        public Queue_Implement(int n)
        {
            queue = new int[n];
        }

        public bool IsEmpty()
        {
            return rear == queue.Length - 1;
        }
        public void EnQueue(int e)
        {
            if (IsEmpty())
            {
                Console.WriteLine("Queue Is Full");
                return;
            }
            queue[rear] = e;
            rear = rear + 1;
            size++;

        }
        public void DeQueue()
        {
            if (size == 0)
            {
                Console.WriteLine("Queue Is Already Empty");
                return;
            }
            int value = queue[front];
            front = front + 1;
            Console.WriteLine(value + "Value Is Already Deleted");
        }

        public int Peek()
        {
            return queue[front];
        }

        public void Display()
        {
            for (int i = front; i < rear; i++)
            {
                
                Console.Write(queue[i] + " -- >");
            }
        }
    }
}
