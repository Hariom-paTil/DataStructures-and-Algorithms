using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures_and_Algorithms.Tree_BinaryTree
{
    //What is Tree?
    //A tree is a hierarchical data structure that consists of nodes connected by edges.
    //Tree cantains a root node and zero or more child nodes, forming a parent-child relationship.
    //What is Binary Tree?
    //A binary tree is a type of tree data structure where each node can have at most two children,
    //referred to as the left child and the right child.
    // Binary trees are widely used in computer science for various applications, including searching,
    // sorting, and representing hierarchical data.
    // In a binary tree, each node contains a value and references to its left and right child nodes.
    // The left child is typically less than or equal to the parent node, while the right child is greater than or equal to the parent node.
    // This property is known as the binary search tree (BST) property, which allows for efficient searching and sorting operations.
    // Binary trees can be classified into different types, such as full binary trees, complete binary trees, and balanced binary trees,
    // In Industry, binary trees are used in various applications, including:
    // 1. Searching and Sorting: Binary search trees (BSTs) are used for efficient searching and sorting of data.
    // 2. Expression Trees: Binary trees can represent mathematical expressions, where each internal node represents an operator and each leaf node represents an operand.
    // 3. Decision Trees: Binary trees are used in machine learning algorithms to represent decision-making processes.
    // 4. Huffman Coding: Binary trees are used in data compression algorithms, such as Huffman coding, to represent variable-length codes.
    // 5. File Systems: Binary trees can be used to represent hierarchical file systems, where directories and files are organized in a tree structure.
    // 6. Network Routing: Binary trees can be used in network routing algorithms to efficiently route data packets.
    // 7. Game Trees: Binary trees are used in game theory to represent possible moves and outcomes in games.
    // 8. Memory Management: Binary trees can be used in memory management algorithms to efficiently allocate and deallocate memory blocks.
    // 9. Database Indexing: Binary trees can be used in database indexing algorithms to efficiently search and retrieve data from large databases.
    // 10. Artificial Intelligence: Binary trees can be used in AI algorithms, such as decision-making and planning, to represent possible actions and outcomes.



    //What is Binary Search Tree?
    // A binary search tree (BST) is a type of binary tree that maintains a specific ordering property.
    // In a BST, for each node:
    // 1. The value of all nodes in the left subtree is less than the value of the current node.
    // 2. The value of all nodes in the right subtree is greater than the value of the current node.
    // This property allows for efficient searching, insertion, and deletion operations in the tree.
    // We implement a binary search tree using a doubly linked list, where each node contains a value and references to its left and right child nodes.
    // The left child reference points to the node with a smaller value, while the right child reference points to the node with a larger value.

    public class Node
    {
        public int element;
        public Node Left;
        public Node right;
        public Node(int e,Node l,Node r)
        {
            element = e;
            Left = l;
            right = r;

        }

    }
    public class BinarySearchTree
    {
        public Node root;
        public BinarySearchTree()
        {
            root = null;
        }

        public void Insert(Node temproot, int e)
        {
            Node temp = null;
            while (temproot != null)  // this while loop is used to traverse the tree and find the "CORRECT POISTION"
                                      // for the new element to be inserted.
            {
                temp = temproot;
                if (e == temproot.element)
                {
                    Console.WriteLine("Element Already Inserted");
                    return;
                }
                else if (temproot.element > e)
                {
                    temproot = temproot.Left;
                }
                else if (temp.element < e)
                {
                    temproot = temproot.right;
                }
            }
            Node node = new Node(e,null,null);
            if (root != null)  // this condition is used to check if the tree is empty or not.
                               // If the tree is empty,
                               // then the new element will be inserted as the root node.
            {
                if (e < temp.element) // temp hold last node of the tree and we are checking if the new element is less than the last node or not.
                {
                    temp.Left = node;
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

        public void InOrder(Node temproot)
        {
            if (temproot != null)
            {
                InOrder(temproot.Left);
                Console.WriteLine(temproot.element);
                InOrder(temproot.right);
            }
        }

    }
}
