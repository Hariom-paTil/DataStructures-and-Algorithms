using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures_and_Algorithms.LinkList
{



    /// <summary>
    /// simple word if want understand you can look this problem suppose you have the multiple boxes [1],[5],[6],[8]
    /// not this no any order you no in future more box will be comes you decide to arrange them in order like when 
    /// you find first box you automaticaly no who is next.
    /// 
    /// step 1 you take first box : means you create first node
    /// the node you store one variable called head=node like this
    /// also in tail=node means it shows that is this starting point of your boxes 
    /// 
    /// now first box address part where next box location should store currntly empty.
    /// 
    /// step 2 now you take second box now you already have a start you just write first address part you second box '
    /// poistion and you do tail.next=node;
    /// node first box get address of second box second box address part currnlty null beacause no more box 
    /// you tail=node means when 3 box will come and we used the node.next so over pointer should second box address not a 
    /// so this how linklist works
    /// 
    ///
    /// 
    /// 
    /// </summary>
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
              Node node = new Node(e, null);// simple word node create with two parts element and address next node
                                            // now [e][add] like this first he created it will like this 
                                            // [5][null]
                                            // head=node means just store starting point of node 
                                            //tail=node both start from first
                                            // tail.next = node  [e][nextnodeadd] 
            if (isEmpty())
            {
                head = node;
                tail = node; // its not object it reference pointer so  only stored the memory that why
                // tail=node it not transfer all the data just a address
        

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


        public void InsertFirst(int e)
        {

            Node node = new Node(e, null);
            node.next = head; // stored the address of the head node in the next of the new node
            head = node; // head is now the new node


        }


    }
}
