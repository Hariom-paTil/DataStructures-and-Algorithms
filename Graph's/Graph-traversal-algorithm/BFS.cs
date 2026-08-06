using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures_and_Algorithms.Graph_s.Graph_traversal_algorithm
{
    public class BFS
    {
        public void BFS_Traversal(int[,] graph, int startNode,int size)
        {
            Queue<int> q = new Queue<int>();
            bool[] visited = new bool[size];

            visited[startNode] = true;
            q.Enqueue(startNode);

            while (q.Count > 0)
            {
                int current = q.Dequeue();
                Console.Write(current + " ");

                for (int j = 0; j < size; j++)
                {
                    if (graph[current, j] == 1 && !visited[j])
                    {
                        visited[j] = true;
                        q.Enqueue(j);
                    }
                }
            }

        }
    }
}
