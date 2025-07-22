        //Simple Struct example in c#

using System;
struct Point
{
    public int X;
    public int Y;

    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }

    public void Display()
    {
        Console.WriteLine($"X = {X}, Y = {Y}");
    }
}
class Solution
{
    static void Main()
    {
        Point p = new Point(10,20);
        p.Display();
    }
}