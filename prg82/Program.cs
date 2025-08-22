        // Graph using Adjacency List

using System;
using System.Collections.Generic;

public class GraphList
{
    private int V;
    private List<int>[] adj;
    
    public GraphList(int vertices)
    {
        V = vertices;
        adj = new List<int>[V];
        for(int i =0;i<V;i++)
        {
            adj[i] = new List<int>();
        }
    }
    public void AddEdge(int u,int v)
    {
        adj[u].Add(v);
    }
    public void RemoveEdge(int u,int v)
    {
        adj[u].Remove(v);
    }
    public bool HasEdge(int u,int v)
    {
        return adj[u].Contains(v);
    }
    public void PrintGraph()
    {
        Console.WriteLine("Adjacency List:");
        for (int i = 0; i < V; i++)
        {   
            Console.Write("Vertex " + i + " -> [");
            for (int j = 0; j < adj[i].Count; j++)
            {
                Console.Write(adj[i][j]);
                if (j < adj[i].Count - 1)
                    Console.Write(", ");
            }
            Console.WriteLine("]");
        }
    }
}

public class Solution
{
    public static void Main(string[] args)
    {
        GraphList g = new GraphList(5);
        g.AddEdge(0,1);
        g.AddEdge(0,2);
        g.AddEdge(1,3);
        g.AddEdge(2,4);
        
        g.PrintGraph();

        Console.WriteLine("Edge 0 -> 1 exists? " + g.HasEdge(0, 1));
        
        g.RemoveEdge(0, 1);
        
        Console.WriteLine("Edge 0 -> 1 exists after removal? " + g.HasEdge(0, 1));
    }
}