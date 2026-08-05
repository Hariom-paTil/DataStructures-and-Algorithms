using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures_and_Algorithms.Graph_s
{
    //What is Graph?
    // A graph is a non-linear data structure that consists of a finite set of vertices (or nodes) and a set of edges that connect pairs of vertices.
    // Graphs are used to represent relationships between objects, and they can be directed or undirected, weighted or unweighted.
    // Graphs are widely used in computer science and various applications, such as social networks, transportation networks, and recommendation systems.
    // There are several types of graphs, including:
    // 1. Directed Graph (Digraph): In a directed graph, edges have a direction, meaning they go from one vertex to another.
    // The edges are represented as ordered pairs (u, v), where u is the starting vertex and v is the ending vertex.
    // 2. Undirected Graph: In an undirected graph, edges do not have a direction, meaning they connect two vertices without any specific order.
    // The edges are represented as unordered pairs {u, v}.
    // 3. Weighted Graph: In a weighted graph, each edge has an associated weight or cost, which can represent distance, time, or any other metric.
    // Weighted graphs can be either directed or undirected.
    // 4. Unweighted Graph: In an unweighted graph, edges do not have any associated weights or costs. Unweighted graphs can also be either directed or undirected.
    // 5. Cyclic Graph: A cyclic graph contains at least one cycle, which is a path that starts and ends at the same vertex.
    //  6. Acyclic Graph: An acyclic graph does not contain any cycles.
    // 7. Connected Graph: A connected graph is a graph in which there is a path between every pair of vertices.
    // 8. Disconnected Graph: A disconnected graph is a graph in which there are at least two vertices that do not have a path between them.
    // 9. Complete Graph: A complete graph is a graph in which there is an edge between every pair of vertices.
    // 10. Bipartite Graph: A bipartite graph is a graph in which the vertices can be divided into two disjoint sets,
    // such that every edge connects a vertex from one set to a vertex from the other set.
    // Graphs can be represented in various ways, including:
    // 1. Adjacency Matrix: A 2D array where the rows and columns represent vertices, and the values indicate whether an edge exists between the corresponding vertices.
    // 2. Adjacency List: A collection of lists or arrays, where each list corresponds to a vertex and contains the vertices that are adjacent to it.
    // 3. Edge List: A list of edges, where each edge is represented as a pair of vertices (and optionally a weight).
    // We are Implementing Graph using Adjacency Matrix.
    /// <summary>
    /// In Matrix Representation, a graph is represented using a 2D array (matrix) where the rows and columns represent the vertices of the graph.
    /// The value at the intersection of a row and column indicates whether there is an edge between the corresponding vertices.
    /// For Example 
    ///   0 1 2 3 4 : representing vertices
    /// 0 0 0 1 0
    /// 1 1 0 0 1
    /// 2 1 1 0 0
    /// 3 0 0 1 0
    /// 4 0 0 0 0
    /// : representing edges between vertices
    /// In this matrix representation, the rows and columns represent the vertices of the graph, and the values indicate whether there is an edge between the corresponding vertices.
    /// 
    /// 
    /// 
    /// 
    /// </summary>
    public class Graph
    {
        public int[,] adjacencyMatrix; // represents the two-dimensional array (matrix) that stores the edges between vertices in the graph.
       public  int vartices; // represents the number of vertices in the graph.
        public Graph(int vertices)
        {
            this.vartices = vertices;
            adjacencyMatrix = new int[vertices, vertices]; // Initialize the adjacency matrix with the specified number of vertices.
        }

        public void InsertElement(int source,int destination)
        {
            adjacencyMatrix[source, destination] = 1; // Set the value at the intersection of the source and destination vertices to 1,
                                                      // indicating an edge exists between them.
        }

        public void ConnectEdge(int source,int destination) // This method is used to connect two vertices in the graph by adding an edge between them.
                                                            // It checks if an edge already exists between the specified source and destination vertices.
                                                            // If an edge already exists, it prints a message indicating that they are already connected.
                                                            // If not, it adds the edge by setting the corresponding value in the adjacency matrix to 1.
        {
            if (adjacencyMatrix[source, destination] == 1)
            {
                Console.WriteLine("Already Connected");
            }
            else
            {
                adjacencyMatrix[source, destination] = 1;
            }
        }
        public bool ContainsEdge(int source,int destination)
        {
            if(adjacencyMatrix[source, destination] == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void RemoveEdge(int source,int destination)
        {
            if (adjacencyMatrix[source, destination] == 1)
            {
                adjacencyMatrix[source, destination] = 0;
            }
            else
            {
                Console.WriteLine("No Edge Found");
            }
        }

        public void FindConnetedNode(int source)
        {
            for(int i = 0; i < vartices; i++)
            {
                if(adjacencyMatrix[source, i] == 1)
                {
                    Console.WriteLine("Connected Node: " + i);
                }
            }
        }


        public void DisplayGraph()
        {
            for (int i = 0; i < vartices; i++)
            {
                for(int j = 0; j < vartices; j++)
                {
                    Console.Write(adjacencyMatrix[i, j] + " ");
                }
                                Console.WriteLine();
            }
        }


    }
}
