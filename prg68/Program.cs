        // List Harshad Numbers up to N

using System;
public class Solution
{
    public static int SumOfDigits(int number)
    {
        int sum = 0;
        while (number > 0)
        {
            sum += number % 10;
            number /= 10;
        }
        return sum;
    }
    
    public static bool IsHarshad(int number)
    {
        int sum = SumOfDigits(number);
        return number % sum == 0;
    }

    public static void Main(string[] args)
    {
        Console.Write("Enter the value of N: ");
        int N = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"\nHarshad numbers up to {N} are:");

        for (int i = 1; i <= N; i++)
        {
            if (IsHarshad(i))
            {
                Console.Write(i + " ");
            }
        }
        Console.WriteLine();
    }
}