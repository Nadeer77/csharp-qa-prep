        // Reverse a string using Recursion (outpur : Hello Friends ~ sdneirf olleH)

using System;

public class Program
{
    public static string Reverse(string str)
    {
        if (str.Length <= 1)
            return str;

        return str[str.Length - 1] + Reverse(str.Substring(0, str.Length - 1));
    }

    public static void Main(string[] args)
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine()!;

        string reversed = Reverse(input);
        Console.WriteLine("Reversed string: " + reversed);
    }
}