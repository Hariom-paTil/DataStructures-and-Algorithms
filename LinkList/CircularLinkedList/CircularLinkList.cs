using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures_and_Algorithms.LinkList.CircularLinkedList
{
    public class Node {

        public int data;
        public Node next;
        public Node(int e,Node n)
        {
            data = e;
            next = n;
        }



    }
    public class CircularLinkList
    {
        public Node head;
        public Node tail;
        public int size;
        public CircularLinkList()
        {
            head = null;
            tail = null;
            size = 0;
        }

        public void AddElementInLast(int e)
        {
            Node newNode = new Node(e, null);
            if (IsEmpty())
            {
                head = newNode;
                tail = newNode;
                size = size + 1;
            }
            else
            {
                tail.next = newNode;
                tail = newNode;
                tail.next = head;
                size = size + 1;
            }


           

        }
        public void Display()
        {
            if (IsEmpty())
            {
                Console.WriteLine("LinkList IS ALREADY EMPTY");
            }
            Node p=head;
            int i = 1;
            while (i <= size)
            {
                Console.Write(" --> " + p.data);
                p=p.next;
                i++;
            }

        }

        public bool IsEmpty()
        {
            return size == 0;
        }

    }
}
