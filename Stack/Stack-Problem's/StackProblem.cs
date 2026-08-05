using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures_and_Algorithms.Stack.Stack_Problem_s
{
    internal class StackProblem
    {

        // Problem form Hackrank-stack selction
        //Find the total height of the 3 stacks. 
        //Keep removing the top cylinder from the tallest stack until all three heights become equal.
        //Return that common height(or 0 if they can only be made equal when all are empty).
        // solution ::
        public static int equalStacks(List<int> h1, List<int> h2, List<int> h3)
        {

            int sum1 = h1.Sum();
            int sum2 = h2.Sum();
            int sum3 = h3.Sum();

            int i = 0, j = 0, k = 0;

            while (true)
            {
                if (sum1 == sum2 && sum2 == sum3)
                    return sum1;

                if (sum1 >= sum2 && sum1 >= sum3)
                {
                    sum1 -= h1[i];
                    i++;
                }
                else if (sum2 >= sum1 && sum2 >= sum3)
                {
                    sum2 -= h2[j];
                    j++;
                }
                else
                {
                    sum3 -= h3[k];
                    k++;
                }

                if (i > h1.Count || j > h2.Count || k > h3.Count)
                {
                    return 0;
                }
            }
        }
    }

}

