//Reverse a string("hello world" ~ "dlrow olleh")

using System;
public class Solution
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the string");
        string input = Console.ReadLine()!;
        string reverse = "";

        for (int i = input.Length - 1; i >= 0; i--)
        {
            reverse += input[i];
        }
        Console.WriteLine("Reversed String : "+reverse);
    }
}