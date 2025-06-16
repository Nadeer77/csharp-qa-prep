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

        //Sum of two numbers using Constructors (another way)

using System;

public class Addition
{
    private int sum;
    public Addition(int a , int b)
    {
        sum = a+b;
    }
    public int GetSum()
    {
        return sum;
    }
    public static void Main(string[] args)
    {
        Addition obj = new Addition(5,10);
        int result = obj.GetSum();
        Console.WriteLine($"Sum of 5 and 10 are: {result}");
    }
}