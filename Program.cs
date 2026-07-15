using DataStructures_and_Algorithms.SearchingAlgorithms;

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



        static void Main(string[] args)
        {

            int[] A = { 23, 45, 67, 8, 8, 34, 66 };

            
            Recursion recursion = new Recursion();
            recursion.DisplayMessage(5);
           Console.WriteLine("Sum of Number : "+recursion.Sum(5));

            // 1:SerachingAlogorithms
            LinearSearch linearSearch = new LinearSearch();
            linearSearch.SearchFunction(A, 34);




            Console.ReadLine();
        }
    }
}
