using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures_and_Algorithms.Heap_DataStructure
{
    

   public class Heap_DS
    {
        public int[] data;
        public int csize;
        public int maxSize;
        public Heap_DS(int size)
        {
            maxSize=size;
            data=new int[size];
        }
        public void Insert(int e)
        {
            if (csize == maxSize)
            {
                Console.WriteLine("Heap is Full");
                return;
            }
            csize = csize + 1;
            int hi = csize;
            while(hi>1 && e > data[hi / 2])
            {
                data[hi] = data[hi / 2]; // root will swap to child if child is greater.
                hi = hi / 2;// root will be empty.
            }
            data[hi] = e; // store the new root on this location.
        }
        public void Display()
        {
            for(int i = 1; i < data.Length; i++)
            {
                Console.WriteLine(data[i]);
            }
        }
    
    }
}
