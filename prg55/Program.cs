// All Exception Handling Examples

// try block (only try, no error occurs)

using System;
public class Program
{
    public static void Main()
    {
        try
        {
            Console.WriteLine("Inside try block.");
            int x = 10 + 5;
            Console.WriteLine("Result: " + x);
        }
        finally
        {
            Console.WriteLine("Finally block always runs.");
        }
    }
}

// try + catch example

using System;
public class Program
{
    public static void Main()
    {
        try
        {
            int x = 10;
            int y = 0;
            int result = x / y;
            Console.WriteLine("Result: " + result);
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Caught: Cannot divide by zero.");
        }
    }
}

// throw (manually throw an exception) example

using System;
public class Program
{
    public static void Main()
    {
        try
        {
            throw new InvalidOperationException("Custom thrown exception");
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine("Caught: " + ex.Message);
        }
    }
}

// finally block (used with try or try-catch) example

using System;
public class Program
{
    public static void Main()
    {
        try
        {
            int[] arr = { 1, 2, 3 };
            Console.WriteLine(arr[5]); // Index out of range
        }
        catch (IndexOutOfRangeException)
        {
            Console.WriteLine("Caught: Index is out of range.");
        }
        finally
        {
            Console.WriteLine("Finally block executed.");
        }
    }
}