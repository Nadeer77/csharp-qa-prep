        // DFS using adjacency matrix

using System;

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

    public void DFSUtil(int v, bool[] visited)
    {
        visited[v] = true;
        Console.Write(v + " ");

        for (int i = 0; i < V; i++)
        {
            if (adj[v, i] == 1 && !visited[i])
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
    static void Main()
    {
        Graph g = new Graph(6);
        g.AddEdge(0, 1);
        g.AddEdge(0, 2);
        g.AddEdge(1, 3);
        g.AddEdge(1, 4);
        g.AddEdge(2, 5);

        g.DFS(0); 
    }
}