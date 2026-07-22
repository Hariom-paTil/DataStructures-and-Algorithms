using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures_and_Algorithms.LinkList
{


    public class Node
    {
        public int element;
        public Node next;
        public Node(int e, Node n) {
        
        element = e;
            next = n;
        
        }
    }
   public class LinksList
    {
        public Node head;
        public Node tail;
        public int size=0;

        public LinksList()
        {
            head = null;
            tail = null;
            size = 0;
        }

        public bool isEmpty()
        {
            return size == 0;
        }
        public void InsertValue(int e)
        {
              Node node = new Node(e, null);
            if (isEmpty())
            {
                head = node;
                tail = node;
        

            }
            else { 
                tail.next = node; // stored the address of the new node in the next of the tail node
                tail = node;    // tail is now the new node 
            }
            size++;
        }

        public void Display()
        {
            Node p = head;
            while (p != null)
            {
                Console.Write(p.element + " -- >");
                p = p.next;
            }


        }





    }
}
