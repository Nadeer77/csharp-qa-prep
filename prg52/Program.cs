        // All Exceptions example

        //Arithmetic Exception example - Occurs during arithmetic operations like division by zero.

using System;
public class Program
{
    public static void Main()
    {
        try
        {
            int a = 10, b = 0;
            int result = a / b;
            Console.WriteLine(result);
        }
        catch (ArithmeticException e)
        {
            Console.WriteLine("Caught: " + e.Message);
        }
    }
}

        //DivideByZero Exception Example - More specific than ArithmeticException.

using System;
public class Program
{
    public static void Main()
    {
        try
        {
            int x = 100;
            int y = 0;
            Console.WriteLine(x / y);
        }
        catch (DivideByZeroException e)
        {
            Console.WriteLine("Caught: " + e.Message);
        }
    }
}

        // Format Exception example - Thrown when converting strings to numbers and the format is invalid.

using System;
public class Program
{
    public static void Main()
    {
        try
        {
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine()); // If user enters letters, error
            Console.WriteLine("You entered: " + num);
        }
        catch (FormatException e)
        {
            Console.WriteLine("Caught: " + e.Message);
        }
    }
}

        //Index Out Of Range Exception example - Occurs when accessing an invalid index in an array.

using System;
public class Program
{
    public static void Main()
    {
        try
        {
            int[] arr = { 1, 2, 3 };
            Console.WriteLine(arr[5]); // Invalid index
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine("Caught: " + ex.Message);
        }
    }
}

        // Null Reference Exception example - Occurs when using an object that is null.

using System;
public class Program
{
    public static void Main()
    {
        try
        {
            string str = null;
            Console.WriteLine(str.Length); // Null object access
        }
        catch (NullReferenceException ex)
        {
            Console.WriteLine("Caught: " + ex.Message);
        }
    }
}

        //FileNotFoundException - Occurs when trying to open a file that does not exist.

using System;
using System.IO;

public class Program
{
    public static void Main()
    {
        try
        {
            StreamReader sr = new StreamReader("nonexistent.txt");
            Console.WriteLine(sr.ReadToEnd());
            sr.Close();
        }
        catch (FileNotFoundException ex)
        {
            Console.WriteLine("Caught: " + ex.Message);
        }
    }
}