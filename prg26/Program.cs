        // find the largest palindrome number in an integer array
        // input  - { 121, 234, 34543, 567, 989, 12321 };

using System;
public class Program
{
    public static bool IsPalindrome(int number)
    {
        int original = number;
        int reversed = 0;
        while (number > 0)
        {
            int digit = number % 10;
            reversed = reversed * 10 + digit;
            number /= 10;
        }
        return reversed == original;
    }
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the array size: ");
        int size = int.Parse(Console.ReadLine()!);
        int[] arr = new int[size];
        for (int i = 0; i < size; i++)
        {
            Console.WriteLine($"Element {i + 1}");
            arr[i] = int.Parse(Console.ReadLine()!);
        }
        int maxPalindrome = -1;
        foreach (int num in arr)
        {
            if (IsPalindrome(num) && num > maxPalindrome)
            {
                maxPalindrome = num;
            }
        }
        if (maxPalindrome != -1)
        {
            Console.WriteLine("The largest palindrome number is: " + maxPalindrome);
        }
        else
        {
            Console.WriteLine("No palindrome numbers found in the array.");
        }
    }
}

using System;

public class Solution
{
    public static bool IsPalindrome(int number)
    {
        int original = number;
        int reversed = 0;

        while (number > 0)
        {
            int digit = number % 10;
            reversed = reversed * 10 + digit;
            number /= 10;
        }

        return original == reversed;
    }

    public static void Main(string[] args)
    {
        int[] arr = { 121, 234, 34543, 567, 989, 12321, 222222 };
        int maxPalindrome = -1;

        foreach (int num in arr)
        {
            if (IsPalindrome(num) && num > maxPalindrome)
            {
                maxPalindrome = num;
            }
        }

        if (maxPalindrome != -1)
        {
            Console.WriteLine("The largest palindrome number is: " + maxPalindrome);
        }
        else
        {
            Console.WriteLine("No palindrome numbers found in the array.");
        }
    }
}