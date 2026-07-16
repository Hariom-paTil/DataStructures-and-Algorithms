using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DataStructures_and_Algorithms.SearchingAlgorithms
{
    public  class LinearSearch
    {
        // What is linear search in C#?
        // Linear search is a simple searching algorithm that checks each element in a list or array.
        // sequentially until the desired element is found or the end of the list is reached.
        // It is also known as sequential search. In C#, linear search can be implemented using loops to iterate through the elements of an array or list and compare each element with the target value.


        public string SearchFunction(int[] array,int value)
        {
            for(int i=0; i <= array.Length; i++)
            {
                if (array[i] == value)
                {
                    return "value is Found :)";
                    
                }
                
               
            }
            return "value is not Found :("; // when we used string int bool at add function thne we need to return value.
                                            // in all condition otherwise it will give error
        }


        // Lets Sloved One Interview Question
        
       // Problem: Given an array of integers and a target value,
       // find the index of the target using Linear Search.
       // If the target is not found, return -1.

        public int LinaerSearchFunction(int[] array,int value)
        {

            for(int i = 0; i < array.Length; i++)
            {
                if (array[i]==value)
                {
                    return i;

                }
            }


            return -1;

        }
    }
}
