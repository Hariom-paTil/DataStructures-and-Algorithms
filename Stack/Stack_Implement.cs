using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

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


        //You are keeping the scores for a baseball game with strange rules. At the beginning of the game, you start with an empty record.

        //        You are given a list of strings operations, where operations[i] is the ith operation you must apply to the record and is one of the following:

        //An integer x.
        //Record a new score of x.
        //'+'.
        //Record a new score that is the sum of the previous two scores.
        //'D'.
        //Record a new score that is the double of the previous score.
        //'C'.
        //Invalidate the previous score, removing it from the record.
        //Return the sum of all the scores on the record after applying all the operations.

        //The test cases are generated such that the answer and all intermediate calculations fit in a 32-bit integer and that all operations are valid.


        // Soution :
        public class Solution
        {
            public int CalPoints(string[] operations)
            {
                int top = 0;
                int[] stack = new int[operations.Length + 2];
                for (int i = 0; i < operations.Length; i++)
                {
                    if (operations[i] == "C")
                    {
                        stack[top] = 0;
                        top--;
                    }
                    else if (operations[i] == "D")
                    {
                        int result = stack[top] * 2;
                        top++;
                        stack[top] = result;
                    }
                    else if (operations[i] == "+")
                    {
                        int result = stack[top - 1] + stack[top];
                        top++;
                        stack[top] = result;
                    }
                    else
                    {
                        top++;
                        stack[top] = int.Parse(operations[i]);

                    }
                }
                int sum = 0;
                for (int i = 0; i <= top; i++)
                {
                    sum = sum + stack[i];
                }

                return sum;
            }
        }

    }
}
