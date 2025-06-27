        // TO check given number is Harshad number or not

using System;
public class Solution
{
    public int SumOfTheDigitsOfHarshadNumber(int x)
    {
        int sum = 0;
        int current = x;

        while (current > 0)
        {
            sum += current % 10;
            current /= 10;
        }

        return x % sum == 0 ? sum : -1;
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter a number to check if it is a Harshad number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        Solution solution = new Solution();
        int result = solution.SumOfTheDigitsOfHarshadNumber(number);

        if (result != -1)
        {
            Console.WriteLine($"{number} is a Harshad number.");
            Console.WriteLine($"Sum of its digits: {result}");
        }
        else
        {
            Console.WriteLine($"{number} is NOT a Harshad number.");
        }
    }
}