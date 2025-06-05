        // Reverse of a Number

using System;

public class Solution
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a number: ");
        int num = Convert.ToInt32(Console.ReadLine());
        int reverse = 0;

        while (num != 0)
        {
            int digit = num % 10;
            reverse = reverse * 10 + digit;
            num = num / 10;
        }
        Console.WriteLine($"Reversed of the given number is {reverse}");
    }
}