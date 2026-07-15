using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures_and_Algorithms
{
    public  class Recursion
    {
        // what is recursion in c#?
        // Recursion is a programming technique where a method calls itself in order to solve a problem. It is often used to solve problems that can be broken down into smaller, similar subproblems. In C#, recursion can be implemented using methods that call themselves with modified parameters until
        // a base case is reached, at which point the recursion stops.

        // Example of recursion in C#:

        public void DisplayMessage(int n)
        {
            if (n >= 0)
            {
                Console.WriteLine("Recusion Called :- "+n);
                DisplayMessage(n - 1);
            }

        }

        // Example 2 sum all numbers

        public int Sum(int n)
        {
            if (n <= 0)
            {
                return 0;
            }
            else
            {
                return n + Sum(n - 1); 
            }
        }

        //types of recusions
        // 1. Direct Recursion: A method calls itself directly.
        // 2. Indirect Recursion: A method calls another method, which in turn calls the first method.
        // 3. Tail Recursion: A method calls itself as its last operation, allowing for optimization by the compiler.
        // 4. Non-Tail Recursion: A method performs additional operations after the recursive call, which can lead to increased memory usage.
        // 5. Infinite Recursion: A method calls itself indefinitely without a base case, leading to a stack overflow error.
        // 6. Mutual Recursion: Two or more methods call each other in a circular manner.
        // 7. Nested Recursion: A method calls itself within another recursive call, creating a nested structure of recursion
    }
}
