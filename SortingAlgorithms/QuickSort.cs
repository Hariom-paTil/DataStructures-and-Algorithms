using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures_and_Algorithms.SortingAlgorithms
{






    //what is quick sort in C#?
    // Quick sort is a divide-and-conquer algorithm that sorts an array by partitioning it into two sub-arrays based on a pivot element.
    // The pivot element is chosen from the array, and the elements are rearranged such that all elements less than the pivot come before it,
    // and all elements greater than the pivot come after it. This process is recursively applied to the sub-arrays until the entire array is sorted.
    public class QuickSort
    {
        public int[] QuickSortFunction(int[] array, int low, int high)
        {


            if (low < high)
            {
                int pivot = FindPivot(array, low, high);
                QuickSortFunction(array, low, pivot - 1);
                QuickSortFunction(array, pivot + 1, high);


            }
            int FindPivot(int[] array, int low, int high)
            {
                int pivot = array[low];
                int i = low+1;
                int j = high;

                while (i < j)
                {
                    while(i<j&& array[i] < pivot)
                    {
                        i++;
                    }
                    while (pivot < array[j])
                    {
                        j--;
                    }
                    if(i<j)
                    {
                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }

                }
               int temp1 = array[j];
                array[j] = array[low];
                array[low] = temp1;
                return j;




            }






            return array;
        }
    }

}
