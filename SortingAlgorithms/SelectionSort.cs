using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

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

        // Let's solve one medium level interview question
        //Sort the IDs in ascending order using Selection Sort and print the array after every pass.
        // INPUT [29, 10, 14, 37, 13]
        //OUTPUT::
        //Pass 1: 10 29 14 37 13
        //Pass 2: 10 13 14 37 29
        //Pass 3: 10 13 14 37 29
        //Pass 4: 10 13 14 29 37

        public int  SelectionSortWithPasses(int[] array) { 
        
            int position = 0;
            for (int i = 0; i < array.Length-1; i++)
            {
                position = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                  
                    if (array[j] < array[position])
                    {
                        position = j;
                    }

                }
                int temp = array[position];
                array[position] = array[i];
                array[i] = temp;
                for(int k = 0; k < array.Length; k++)
                {
                    Console.Write(array[k] + " "); 
                }
                Console.WriteLine("\n");
            }

            return 1;

        }

        // WHAT WE LEARN FORM THIS PROBLEM 
        // <= check the array length in for loop
        // checks the conditio when weiting is it correct or not
        // Console.Write(array[k] + " "); used this when we want to print the array in same line



    }
}
