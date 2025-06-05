        //Sum of two numbers using Constructors

using System;
public class Addition
{
    public Addition(int a, int b)
    {
        int sum = a + b;
        Console.WriteLine($"sum of {a} and {b} is : {sum}");
    }
}
public class Example
{
    public static void Main(string[] args)
    {
        Addition obj = new Addition(5, 10);
    }
}