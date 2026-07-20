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


        //

    }
}
