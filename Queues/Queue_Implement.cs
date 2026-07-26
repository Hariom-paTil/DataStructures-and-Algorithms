using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures_and_Algorithms.Queue
{
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
