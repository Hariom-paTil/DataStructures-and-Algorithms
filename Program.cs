using DataStructures_and_Algorithms.DSA_Problem_s;
using DataStructures_and_Algorithms.LinkList.CircularLinkedList;
using DataStructures_and_Algorithms.LinkList.SingleLinkList;
using DataStructures_and_Algorithms.Queue;
using DataStructures_and_Algorithms.SearchingAlgorithms;
using DataStructures_and_Algorithms.SortingAlgorithms;
using DataStructures_and_Algorithms.Stack;
using DataStructures_and_Algorithms.Tree_BinaryTree;

namespace DataStructures_and_Algorithms
{
    //Before sloving in DSA problem you need to understand the below point's
    //1: learn the basic of C# fundamental's.
    // 2: learn the basic of C# OOP's concept.
    // 3: First learn all the topics of DSA 
    // Like Searching, Sorting, Stack, Queue, LinkList, Tree, Graph, Hashing etc.
    // 4: After that Learn how to undersyand the problem statement and how to solve it.
    // 5: after that watch the video of problem statement and how to solve it.
    // 6: then start sloving easy problem of all topic's 
    // 7: onece you will be comfortable with easy problem then start solving medium problem of all topic's



    //HOW TO DEBUG C# PROGRAM :
    //how to debug add red pointer on poistion where you want start the debug 
    //run the program once's you will go to this poistion press F10 it run next -next step;s
    // for checking the what value the variable currnlty hold click on Debug Menu--> Window-->Locals here
    //you check what varible currnty value was.
    public class Program
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

            int[] A = { 23, 45, 67, 8, 8, 34, 66, 67 },
                b = { 1, 2, 3, 4, 5 },
                c = { 7, 10, 1, 3, 6, 9, 2 }, revInput = { 1, 4, 3, 2, 6, 5 }, 
                con = { 0, 1, 0, 1, 1, 1, 1 }, con2 = { 0, 0, 1, 0, 1, 0 }, 
                con3 = { 0, 0, 0, 0 }, zeroFinder = { 1, 2, 0, 4, 3, 0, 5, 0 };

            

            
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
            //int[] result = quickSort.QuickSortFunction(A, 0, A.Length - 1);
            //foreach(int item in result)
            {
           //    Console.Write(item + " ");
            }

            //Console.WriteLine("Second Largest Element"+linearSearch.getSecondLargest(A));

            ArrayProblem arrayProblem = new ArrayProblem();
            // Console.WriteLine("Second Largest Element : "+arrayProblem.SecondLargestElement(A));
            // int[] result= arrayProblem.ReverseArray(revInput);
            // foreach(int item in result)
            // {
            //     Console.Write(item + " ");
            // }

            //LinksList linksList = new LinksList();
            //linksList.InsertValue(10);
            //linksList.InsertValue(11);
            //linksList.InsertValue(12);
            //linksList.Display();
            //Console.WriteLine("\n");
            //linksList.InsertFirst(9);
            //linksList.Display();
            //Console.WriteLine(linksList.AnyPosition(15, 3));
            //linksList.Display();
            //Console.WriteLine(linksList.DeleteFirst());
            //linksList.Display();


            LinkListPractice linkListPractice = new LinkListPractice();
            //linkListPractice.InsertElement(10);
            //linkListPractice.InsertElement(20);
            //linkListPractice.InsertElement(30);
            //linkListPractice.Display();
            //linkListPractice.DeletedFirst();
            //linkListPractice.Display();
            //arrayProblem.Consecutive(con);
            //arrayProblem.Consecutive(con2);
            //arrayProblem.Consecutive(con3);

            //arrayProblem.MoveZeros(zeroFinder);
            //int[] result = arrayProblem.SortArrayWave(b);
            //foreach (int item in result) { 

            //Console.WriteLine(item + " ");

            //}


            //CircularLinkList circularLinkList = new CircularLinkList();
            //circularLinkList.AddElementInLast(10);
            //circularLinkList.AddElementInLast(20);
            //circularLinkList.AddElementInLast(30);
            //circularLinkList.AddElementInLast(40);
            //circularLinkList.InsertFirst(5);
            //circularLinkList.Display();


            //Console.WriteLine(arrayProblem.MaxProfitInStock(c));

            //Stack_Implement stack_ = new Stack_Implement(5);
            //stack_.PushElement(10);
            //stack_.PushElement(20);
            //stack_.PushElement(30);
            //stack_.PushElement(40);
            //stack_.PushElement(50);
            //stack_.PushElement(60);
            //stack_.Display();
            //Console.WriteLine(stack_.PopElement());
            //Console.WriteLine(stack_.Peek());
            //stack_.Display();


            //Queue_Implement queue_ = new Queue_Implement(5);
            //queue_.EnQueue(10);
            //queue_.EnQueue(20);
            //queue_.EnQueue(30);
            //queue_.Display();
            //Console.WriteLine("Peek Element"+queue_.Peek());


            BinarySearchTree binarySearchTree = new BinarySearchTree();
            binarySearchTree.Insert(binarySearchTree.root, 30);
            binarySearchTree.Insert(binarySearchTree.root, 20);
            binarySearchTree.Insert(binarySearchTree.root, 60);
            binarySearchTree.Insert(binarySearchTree.root, 40);
            binarySearchTree.Insert(binarySearchTree.root,50);
            binarySearchTree.Insert(binarySearchTree.root,10);
            Console.WriteLine("InOrder Traversal of Binary Search Tree:");
            binarySearchTree.InOrder(binarySearchTree.root);
            binarySearchTree.SearchTree(binarySearchTree.root, 100);
            


            Console.ReadLine();
        }
    }
}
