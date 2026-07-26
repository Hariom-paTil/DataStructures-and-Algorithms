using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures_and_Algorithms.Stack
{

    //What Is Stack?
    //Stack is a linear data structure that follows the Last In First Out (LIFO) principle. It means that the last element added to the stack will be the first one to be removed.
    //Think of it like a stack of plates; you can only add or remove the top plate.
    //In a stack, there are two main operations:
    //Push: This operation adds an element to the top of the stack.
    //Pop: This operation removes the top element from the stack.
    //Other operations include:
    //Peek: This operation returns the top element of the stack without removing it.

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
