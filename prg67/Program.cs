        //Method Overloading Example

using System;

public class Calculator
{
    // Method 1: Add two integers
    public int Add(int a, int b)
    {
        return a + b;
    }

    // Method 2: Add three integers
    public int Add(int a, int b, int c)
    {
        return a + b + c;
    }

    // Method 3: Add two doubles
    public double Add(double a, double b)
    {
        return a + b;
    }

    // Method 4: Add an integer and a double
    public double Add(int a, double b)
    {
        return a + b;
    }

    // Method 5: Add a double and an integer
    public double Add(double a, int b)
    {
        return a + b;
    }

    public static void Main(string[] args)
    {
        Calculator calc = new Calculator();

        Console.WriteLine("Add(int, int): " + calc.Add(5, 10));
        Console.WriteLine("Add(int, int, int): " + calc.Add(1, 2, 3));
        Console.WriteLine("Add(double, double): " + calc.Add(2.5, 3.5));
        Console.WriteLine("Add(int, double): " + calc.Add(4, 2.5));
        Console.WriteLine("Add(double, int): " + calc.Add(2.5, 4));
    }
}