using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures_and_Algorithms.SortingAlgorithms
{
    public class SelectionSort
    {
        //What is selection sort in C#?
        // Selection sort is a simple comparison-based sorting algorithm that works by repeatedly.
        // selecting the smallest (or largest) element from the unsorted portion of the list and moving it to the sorted portion. The algorithm divides the input list into two parts: a sorted part and an unsorted part.
        // It repeatedly selects the minimum (or maximum) element from the unsorted part and swaps it with the first unsorted element, effectively growing the sorted part of the list one element at a time.

        public int[] SelectionSortFunction(int[] array)
        {
            for(int i=0; i<array.Length-1; i++)
            {
                int position = i;
                for (int j=i+1; j<array.Length; j++)
                {
                   if (array[j] < array[position])
                    {
                        position = j;
                    }
                }
                int temp=array[position];
                array[position] = array[i];
                array[i] = temp;
            }

            return array;
        }

    }
}
