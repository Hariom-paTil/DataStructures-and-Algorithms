using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures_and_Algorithms.Stack
{
    public class Stack_Implement
    {
        public int[] stack;
        public int top = 0;
        
        public Stack_Implement(int n)
        {
            stack = new int[n];
            top = 0;
        }

        public bool IsFull()
        {
            return top == stack.Length - 1;
        }
        public string PushElement(int e)
        {
            if (IsFull())
            {
                return "Stack**Alredy**Full";
            }
            else
            stack[top] = e;
            top = top + 1;
            return e + "Value Inserted In Stack";

        }
        public string PopElement()
        {
            if (top == 0)
            {
                return "Stack Already Empty";
            }
            int value = stack[top - 1];
            top = top - 1;
            return value + "Element Remove Form Stack";

        }

        public string  Peek()
        {
            return "Top Element OF Stack"+stack[top - 1];
        }

        public int Size()
        {
            return top - 1;
        }

        public void Display()
        {
            for(int i = top; i > 0  ; i--)
            {
                Console.WriteLine(" " + stack[i]);
            }
            
        }

    }
}
