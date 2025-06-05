        // Fibonacci Series

using System;
public class Solution
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the number of terms: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int a = 0, b = 1, next;
        Console.WriteLine("Fibonacci Series: ");
        for (int i = 0; i < n; i++)
        {
            if (i <= 1)
            {
                next = i;
            }
            else
            {
                next = a + b;
                a = b;
                b = next;
            }
            Console.Write(next + " ");
        }
    }
}