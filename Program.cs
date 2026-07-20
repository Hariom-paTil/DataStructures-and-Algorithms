using DataStructures_and_Algorithms.DSA_Problem_s;
using DataStructures_and_Algorithms.SearchingAlgorithms;
using DataStructures_and_Algorithms.SortingAlgorithms;

namespace DataStructures_and_Algorithms
{
   public  class Program
    {
        // **IMPORTANT**:
        // why we not used string ? when perform revrse the number because
        // string is immutable in C# and it will create new string object every time we
        // perform operation on it. So, we use int to perform reverse number operation.


        //before goto new keyword C# memory Allocation
        //C# memory divided into two parts 1: Stack Memory 2: Heap Memory
        // ||STACK MEMORY||:  stack memory used for value type and reference type variable which is created in method or function.
        // Stack memory is used for static memory allocation. Stack memory is faster than heap memory.
        // Stack memory is used for local variables, method parameters, and return addresses
        // ||HEAP MEMORY||: heap memory used for reference type variable which is created in method or function.
        //for example object, class, array, string, delegate, etc.




        // Why we used new keyword ?
        // new keyword used for many resons like to create object, to hide base class member,
        // to create instance of anonymous type, to create instance of delegate, to create instance of dynamic type,
        // to create instance of nullable type, to create instance of tuple type, to create instance of record type,
        // to create instance of struct type, to create instance of enum type, to create instance of interface type,
        // to create instance of array type, to create instance of pointer type, to create instance of generic type,
        // to create instance of nested type, to create instance of local function, to create instance of lambda expression, to create instance of async method, to create instance of iterator method, to create instance of extension method,
        // to create instance of partial method, to create instance of static constructor,
        // to create instance of finalizer.



       public static void Main(string[] args)
        {

            int[] A = { 23, 45, 67, 8, 8, 34, 66 ,67}, b = {12,22,44,55,66,77,88} , c = { 29, 10, 14, 37, 13 }; 
            

            
            //Recursion recursion = new Recursion();
            //recursion.DisplayMessage(5);
           //Console.WriteLine("Sum of Number : "+recursion.Sum(5));

            // 1:SerachingAlogorithms
            LinearSearch linearSearch = new LinearSearch();
           // Console.WriteLine("Result Of LinearSearch :"+linearSearch.SearchFunction(A, 34));
            //Console.WriteLine("Location of Element In Array :"+linearSearch.LinaerSearchFunction(A, 90));
           // BinarySearch binarySearch = new BinarySearch();
           // Console.WriteLine("Result Of BinarySearch :"+binarySearch.BinarySearchFunction(b, 22));
            //Console.WriteLine("Location of Element In BinarySearchArray :"+binarySearch.BinarySearchFunctionIndex(b, 22));




            // 2:SortingAlgorithms
            SelectionSort selectionSort = new SelectionSort();
            //int[] sortedArray = selectionSort.SelectionSortFunction(A);
            //Console.WriteLine("SelectionSort :)");
             //foreach(int item in sortedArray)
             //{
             //   Console.Write(item + " ");
           // }
            //Console.WriteLine(""+selectionSort.SelectionSortWithPasses(c));


            BubbleSort bubbleSort = new BubbleSort();
            QuickSort quickSort = new QuickSort();
            //bubbleSort.BubbleSortFunction(A);
           // Console.WriteLine(" Check"+bubbleSort.FindPass(c));
            int[] result = quickSort.QuickSortFunction(A, 0, A.Length - 1);
            foreach(int item in result)
            {
           //    Console.Write(item + " ");
            }

            //Console.WriteLine("Second Largest Element"+linearSearch.getSecondLargest(A));

           ArrayProblem arrayProblem = new ArrayProblem();
            Console.WriteLine("Second Largest Element : "+arrayProblem.SecondLargestElement(A));

            Console.ReadLine();
        }
    }
}
