using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures_and_Algorithms.LinkList.DoublyLinkList
{

    public class Node {

        public int element;
        public Node next;
        public Node prev;
         public Node(int e,Node n,Node p)
        {
            element = e;
            next = n;
            prev = p;


        }
    
    }
    public class DoublyLinksList
    {
        public int size;
        public Node head;
        public Node tail;
        public DoublyLinksList()
        {
            head = null;
            tail = null;
            size = 0;


        }
        public void  InsertElement(int e)
        {
            Node newNode = new Node(e,null,null);
            if (IsEmpty())
            {
                head = newNode;
                tail = newNode;
                size++;
            }
            else
            {
                tail.next = newNode;
                newNode.prev = tail;
                tail = newNode;
                size++;
                
            }

        }
        public bool IsEmpty()
        {
            return size == 0;
        }
    }
}
