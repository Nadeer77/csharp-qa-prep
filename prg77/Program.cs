        // BFS in Adjacency List

using System;
using System.Collections.Generic;

class Graph
{
    private int V;
    private List<int>[] adj;

    public Graph(int vertices)
    {
        V = vertices;
        adj = new List<int>[V];
        for (int i = 0; i < V; i++)
            adj[i] = new List<int>();
    }

    public void AddEdge(int v, int w)
    {
        adj[v].Add(w);
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

            foreach (int i in adj[v])
            {
                if (!visited[i])
                {
                    visited[i] = true;
                    queue.Enqueue(i);
                }
            }
        }
        Console.WriteLine();
    }
}

class Program
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