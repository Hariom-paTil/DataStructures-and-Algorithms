using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DataStructures_and_Algorithms.DSA_Problem_s
{
    public class ArrayProblem
    {
        //PROBLEM 1 :Given an array of positive integers arr[] of size n, the task is to find second largest distinct element in the array.
        // Note: If the second largest element does not exist, return -1.

        public int SecondLargestElement(int[] arr)
        {

            int first = arr[0];
            int second = 0;
            for (int i = 0; i < arr.Length-1; i++)
            {
                if (arr[i] < arr[i + 1])
                {
                    second = first;
                    first = arr[i + 1];

                }


            }
            if (second == first)
            {
                return -1;
            }
            else
            {
                return second;


            }
        }


        //Reverse an array arr[].
        //Reversing an array means rearranging the elements such that the first element becomes the last,
        //the second element becomes second last and so on.
        //Input: arr[] = [1, 4, 3, 2, 6, 5]  
        //Output:  [5, 6, 2, 3, 4, 1]
        //Explanation: The first element 1 moves to last position, the second element 4 moves to second-last and so on.


        //Sloved this problem using two pointer approach
        public int[] ReverseArray(int[] arr)
        {
            int pointer = arr.Length-1;

            for(int i = 0; i < arr.Length - 1; i++)
            {
                if (i<pointer)
                {
                    int temp = arr[i];
                    arr[i] = arr[pointer];
                    arr[pointer] = temp;
                    pointer--;
                }
                else
                {
                    return arr;
                }



            }
            

            return arr;


        }
        //Maximum consecutive one’s (or zeros) in a binary array
        //[0, 1, 0, 1, 1, 1, 1]

        public void Consecutive(int[] a)
        {
            int oneCount = 1;
            int zeroCount = 1;//start form because we checked array as Length-1;
            for (int i = 0; i < a.Length - 1; i++)
            {
                if (a[i] == 0 && a[i + 1] == 0)
                {

                    zeroCount++;

                }
                if (a[i] == 1 && a[i + 1] == 1)
                {
                    oneCount++;
                }


            }
            if (oneCount > zeroCount)
            {
                Console.WriteLine("Maximum Consecutive One's : " + oneCount);
            }
            else
            {
                Console.WriteLine("Maximum Consecutive Zero's : " + zeroCount);
            }
        }


        //Move all Zeros to End of Array

        public void MoveZeros(int[] a)
        {
            int pointer = a.Length - 1;
            for (int i = 0; i < pointer; i++)
            {
                if (a[i] == 0)
                {
                    // check that pointer is not pointing to zero and decrement the pointer until it points to
                    // non-zero element
                    while (a[pointer] == 0)
                    {
                        pointer--;
                    }


                    int temp = a[i];
                    a[i] = a[pointer];
                    a[pointer] = temp;
                    pointer--;
                }

            }

            foreach(int item in a)
            {
               Console.Write(item + " ");
            }
        }

        //Sort an array in wave form
        //Input: arr[] = [1, 2, 3, 4, 5]
        //Output: [2, 1, 4, 3, 5]

        public int[] SortArrayWave(int[] a)
        {
            bool check=true;
            int start = 0;
            while (start < a.Length - 1)
            {
                if (check)
                {
                    int temp = a[start+1];
                    a[start + 1] = a[start];
                    a[start] = temp;
                    check = false;
                    start = start + 2;

                }
                else
                {
                    int temp = a[start];
                    a[start] = a[start + 1];
                    a[start + 1] = temp;
                    check = true;
                    start = start + 2;
                }
                
            }
            return a;

        }


    }
}
