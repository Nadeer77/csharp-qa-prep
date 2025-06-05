        //Running Sum for a given number

using System;
public class Solution
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the number: ");
        int num = Convert.ToInt32(Console.ReadLine());

        int sum = 0;
        while (num != 0)
        {
            sum += num % 10;
            num = num / 10;
        }
        Console.WriteLine($"Running sum : {sum}");
    }
}