        // Data Abstraction using Interface

using System;
public interface IShape
{
    public void Draw();
}
public class Circle : IShape
{
    public void Draw()
    {
        Console.WriteLine("Drawing a Circle");
    }
}
class Solution
{
    public static void Main(string[] args)
    {
        IShape obj = new Circle();
        obj.Draw();
    }
}