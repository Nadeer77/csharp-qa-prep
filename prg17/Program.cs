//GCD of Two Numbers

using System;
public class Solution
{
    public static int FindGCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the first number:");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the second number:");
        int num2 = Convert.ToInt32(Console.ReadLine());

        int result = FindGCD(num1, num2);
        Console.WriteLine($"GCD of {num1} and {num2} is: {result}");
    }
}