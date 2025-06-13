        //Nested if example

using System;

public class Program
{
    public static void Main()
    {
        Console.Write("Enter a number: ");
        int num = Convert.ToInt32(Console.ReadLine());

        if (num > 0)
        {
            Console.WriteLine("The number is positive.");

            if (num % 2 == 0)
            {
                Console.WriteLine("The number is even.");
            }
            else
            {
                Console.WriteLine("The number is odd.");
            }
        }
        else if (num < 0)
        {
            Console.WriteLine("The number is negative.");
        }
        else
        {
            Console.WriteLine("The number is zero.");
        }
    }
}
