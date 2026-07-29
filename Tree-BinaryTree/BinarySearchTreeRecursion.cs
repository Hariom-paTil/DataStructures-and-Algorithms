using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures_and_Algorithms.Tree_BinaryTree
{


    // Binary Tree Using Recursion
    // Which method is better for binary tree implementation, recursion or iteration?
    // The choice between recursion and iteration for binary tree implementation depends on the specific use case and the characteristics of the tree.
    // Recursion is often more intuitive and easier to implement for tree traversal algorithms, such as in-order, pre-order, and post-order traversals.
    // It allows for a cleaner and more concise code structure,
    // especially when dealing with recursive tree structures. However, recursion can lead to stack overflow errors for very deep trees,
    // as each recursive call adds a new frame to the call stack.
    // Iteration, on the other hand, can be more efficient in terms of memory usage, as it avoids the overhead of recursive function calls.
    // Iterative approaches often use explicit stacks or queues to manage the traversal process. However,
    // iterative implementations can be more complex and less intuitive than their recursive counterparts.
    // In general, for balanced binary trees or trees with limited depth, recursion is often preferred for its simplicity and readability.
    // For very deep or unbalanced trees, iteration may be a better choice to avoid stack overflow issues.
    // final answer: Both recursion and iteration have their advantages and disadvantages for binary tree implementation.
    // The choice between the two approaches depends on the specific use case, the characteristics of the tree,
    // and the trade-offs between simplicity, readability, and memory efficiency.
    public class Nodes
    {
        public int element;
        public Nodes left;
        public Nodes right;

        public Nodes(int e,Nodes l,Nodes r)
        {
            element = e;
            left = null;
            right = null;

        }

    }
    public  class BinarySearchTreeRecursion
    {
        public Nodes root;
        public Nodes temp;
        public BinarySearchTreeRecursion()
        {
            root = null;
        }
        public void Insert(Nodes tempRoot,int e)
        {
            
            if (tempRoot != null)
            {
                 temp = tempRoot;
                if (tempRoot.element == e)
                {
                    Console.WriteLine("Element Already Present In Treee");
                    return;

                }
                else if (tempRoot.element > e)
                {
                    Insert(tempRoot = tempRoot.left, e);

                }
                else if (tempRoot.element < e)
                {
                    Insert(tempRoot = tempRoot.right, e);
                }
            }

            Nodes node = new Nodes(e, null,null);
            if (root != null)
            {
                if (temp.element > e)
                {
                    temp.left = node;
                }
                else
                {
                    temp.right = node;
                }
            }
            else
            {
                root = node;
            }

        }

        public void Inorder(Nodes tempRoot)
        {
            if (tempRoot != null)
            {
                Inorder(tempRoot.left);
                Console.WriteLine(" "+tempRoot.element);
                Inorder(tempRoot.right);
            }
        }
    }
}
