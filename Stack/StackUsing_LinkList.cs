using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace DataStructures_and_Algorithms.Stack
{
    public class Nodes
    {
        public Nodes next;
        public int data;
        
        public Nodes(Nodes n, int d)
        {
           next = n;
          data = d;
        }
    }
    public class StackUsing_LinkList
    {
        public Nodes Top;
      
        int size = 0;

        public StackUsing_LinkList()
        {
            Top = null;
          
            
        }
        public void Push(int n)
        {
            Nodes newNode = new Nodes(Top, n);
            newNode.next = Top;
            Top = newNode;


        }
        public bool IsEmpty()
        {
            return size == 0;
        }

        public void DisplayStack()
        {
            Nodes t = Top;
            while(t!=null)
            {
                Console.WriteLine(t.data);
                t = t.next;
            }
        }

        public void Pop() {

            int value = Top.data;
            Console.WriteLine(value + " ");
            Top = Top.next;


        }

    }
}
