using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures_and_Algorithms.SortingAlgorithms
{
    public class BubbleSort
    {

        // What is bubble sort in C#?
        // Bubble sort is a simple comparison-based sorting algorithm that works by repeatedly stepping through the list
        // to be sorted,
        // comparing adjacent elements and swapping them if they are in the wrong order. The pass through the list is
        // repeated until the list is sorted. The algorithm gets its name because smaller elements "bubble" to the top
        // of the list while larger elements "sink" to the bottom.

        public void BubbleSortFunction(int[] array)
        {

            for(int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - i - 1; j++)
                { 
                    if(array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }   
                }
            }

            for(int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
    }
}
