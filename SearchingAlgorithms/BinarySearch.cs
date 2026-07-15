using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures_and_Algorithms.SearchingAlgorithms
{
    public class BinarySearch
    {
        // What is binary search in C#?
        // Binary search is a searching algorithm that finds the position of a target value within a sorted array or list.
        // It works by repeatedly dividing the search interval in half. If the value of the target is less than the value in the middle of the interval, the search continues in the lower half. Otherwise, it continues in the upper half. This process repeats until the target value is found or the interval is empty.
        
        public string BinarySearchFunction(int[] array, int value)
        {

            int mid;
            int start = 0, end = array.Length-1;
        
            
            while (start <= end)
            {
                mid = (start + end) / 2;
                if (array[mid] == value)
                {
                    return "Value Found On Position :" + mid;
                
                }
                else if (array[mid] < value)
                {
                    start = mid + 1;   
                }
                else
                {
                    end = mid - 1;     
                }

            }
            return "Value Not Found :(";

        }
    }
}
