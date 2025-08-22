        // BFS using adjacency matrix

using System;
using System.Collections.Generic;

class Graph
{
    private int V;
    private int[,] adj;

    public Graph(int vertices)
    {
        V = vertices;
        adj = new int[V, V]; 
    }

    public void AddEdge(int v, int w)
    {
        adj[v, w] = 1;
    }

    public void BFS(int start)
    {
        bool[] visited = new bool[V];
        Queue<int> queue = new Queue<int>();

        visited[start] = true;
        queue.Enqueue(start);

        Console.Write("BFS Traversal: ");
        while (queue.Count > 0)
        {
            int v = queue.Dequeue();
            Console.Write(v + " ");

            for (int i = 0; i < V; i++)
            {
                if (adj[v, i] == 1 && !visited[i])
                {
                    visited[i] = true;
                    queue.Enqueue(i);
                }
            }
        }
        Console.WriteLine();
    }
}

class Solution
{
    static void Main()
    {
        Graph g = new Graph(6);
        g.AddEdge(0, 1);
        g.AddEdge(0, 2);
        g.AddEdge(1, 3);
        g.AddEdge(1, 4);
        g.AddEdge(2, 5);

        g.BFS(0); 
    }
}