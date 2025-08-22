        // Graph using Adjacency Matrix

using System;
public class GraphMatrix
{
    private int V;
    private int[,] matrix;
    public GraphMatrix(int vertices)
    {
        V = vertices;
        matrix = new int[V,V];
    }
    public void AddEdge(int u,int v)
    {
        matrix[u,v]=1;
    }
    public void RemoveEdge(int u,int v)
    {
        matrix[u,v]=0;
    }
    public bool HasEdge(int u,int v)
    {
        return matrix[u,v] == 1;
    }
    public void PrintGraph()
    {
        Console.WriteLine("Adjacency Matrix: ");
        for(int i=0;i<V;i++)
        {
            for(int j=0;j<V;j++)
            {
                Console.Write(matrix[i,j]+" ");
            }
            Console.WriteLine();
        }
    }
}

public class Solution
{
    public static void Main(string[] args)
    {
        GraphMatrix g = new GraphMatrix(5);
        g.AddEdge(0,1);
        g.AddEdge(0,2);
        g.AddEdge(1,3);
        g.AddEdge(2,4);
        
        g.PrintGraph();
        
        Console.WriteLine("Edge 0 → 1 exists? " + g.HasEdge(0, 1));
        g.RemoveEdge(0, 1);
        Console.WriteLine("Edge 0 → 1 exists after removal? " + g.HasEdge(0, 1));
    }
}