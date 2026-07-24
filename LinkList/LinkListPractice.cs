using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures_and_Algorithms.LinkList
{
    public class Nodes {
        public int element;
        public Nodes next;
        public Nodes(int e,Nodes n)
        {
            element = e;
            next = n;

        }
    
    
    }
    public class LinkListPractice
    {
        public int size;
        public Nodes head;
        public Nodes tail;
        
        public LinkListPractice()
        {
            head = null;
            tail = null;
            size = 0;
        }

        public void InsertElement(int n)
        {
            Nodes node = new Nodes(n,null);
            if (IsEmpty())
            {
                head = node;
                tail = node;
                size++;
            }
            else
            {
                tail.next = node;
                tail = node;
                size++;

            }



        }
        public void Display()
        {
            Nodes p = head; // we just store first node address in head 
            while(p != null)
            {
                Console.WriteLine(p.element+"-->");
                p = p.next; //evry new node containes next node address
            }
        }
        public string InsertAtAnyPoistion(int e, int position) {

            Nodes p= head;
            Nodes anyposition = new Nodes(e,null);
            if (IsEmpty() || position < size)
            {
                return "Invalid poistion";
            }
            int start = 1;
            while (start < size)
            {
                p = p.next;
                start++;
            }
            anyposition.next = p.next; // p.next is second number node and we want insert value on thard node
                                        // so we creted new node thard node now second node addres we store
                                        // thard node address
                                        //in second node next so we can access thard node from second node
                p.next = anyposition;
            size++;
            return "Value Inserted";

         
            
            
            }
        public bool IsEmpty()
        {
            return size == 0;
        }

        public string DeletedFirst()
        {
            int e = head.element;
            head = head.next;
            return e + "Element Deleted";


        }
    }
}
