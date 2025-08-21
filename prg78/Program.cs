        // DFS in Adjacency List

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

    public void DFSUtil(int v, bool[] visited)
    {
        visited[v] = true;
        Console.Write(v + " ");

        foreach (int i in adj[v])
        {
            if (!visited[i])
                DFSUtil(i, visited);
        }
    }

    public void DFS(int start)
    {
        bool[] visited = new bool[V];
        Console.Write("DFS Traversal: ");
        DFSUtil(start, visited);
        Console.WriteLine();
    }
}
class Program
{
    public static void Main()
    {
        Graph g = new Graph(6);
        // g.AddEdge(0, 1);
        // g.AddEdge(0, 2);
        // g.AddEdge(1, 3);
        // g.AddEdge(1, 4);
        // g.AddEdge(2, 5);
        g.AddEdge(0,1);
        g.AddEdge(0,2);
        g.AddEdge(1,2);
        g.AddEdge(2,0);
        g.AddEdge(2,3);
        g.AddEdge(3,3);

        g.DFS(2); 
    }
}