using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures_and_Algorithms.Queues
{
    public class Nodes{

        public Nodes next;
        public int data;

        public Nodes(Nodes next, int data)
        {
            this.next = next;
            this.data = data;
        }
    }
    public class QueueUsing_LinkList
    {
        public Nodes rearHead;
        public Nodes frontHead;
        int size = 0;
        public QueueUsing_LinkList()
        {
            rearHead = null;
            frontHead = null;
        }
        public void EnQueue(int n)
        {
            Nodes node = new Nodes(null, n);
            if (IsEmpty())
            {
                rearHead = node;
                frontHead = node;
                size++;
            }
            else
            {
                rearHead.next = node;
                rearHead = node;
                size++;
            }
        }
        public bool IsEmpty()
        {
            return size == 0;
        }

        public void DisplayQueue()
        {
            Nodes f = frontHead;
            while (f != null)
            {
                Console.WriteLine(f.data + " ");
                f = f.next;
            }
        }

        public void DeQueue()
        {
            if (IsEmpty()) {                 
                Console.WriteLine("Queue is Empty");
                return;
            }
            else
            {
                frontHead = frontHead.next;
                size--;

            }
        }

    }
    
}
