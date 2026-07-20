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

    }
}
