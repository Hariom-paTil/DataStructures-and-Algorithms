using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures_and_Algorithms.Heap_DataStructure
{
    public class HeapPractice
    {
        public int[] data;
        public int heapSize = 0;
        int rootfinder = 0;
        public int  maxSize;

        public HeapPractice(int n)
        {
            data=new int[n];
            maxSize=n;
        }
        public void Insert(int e)
        {
            if (heapSize == maxSize) { Console.WriteLine("Heap is Full ");  }
            heapSize = heapSize + 1;
            rootfinder = heapSize;
            while (rootfinder > 1 && e > data[rootfinder / 2])
            {
                data[rootfinder] = data[rootfinder / 2];
                rootfinder = rootfinder / 2;
            }
            data[rootfinder] = e;
            
        }
        public int DeletedElement()
        {
            int deletedValue = data[1];
            data[1] = data[heapSize];
            data[heapSize] = -1;
            heapSize = heapSize - 1;
            int j = 0;
            int i = 1;
            j = j * i;
            while (j <= heapSize)
            {
                if (data[j] < data[j + 1])
                {
                    j = j + 1;
                }
                if (data[i] < data[j + 1])
                {
                    int temp = data[i];
                    data[i] = data[j];
                    data[j] = temp;
                }
                i = j;
                j = i * i;
            }
            return deletedValue;

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
