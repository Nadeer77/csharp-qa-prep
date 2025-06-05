// Count the prime numbers in an array

using System;
public class Solution
{
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
        int count = 0;
        Console.Write("Prime numbers are : ");
        foreach (int i in arr)
        {
            if (IsPrime(i))
            {
                Console.Write(i + "  ");
                count++;
            }
        }
        Console.WriteLine("Prime Number Count: "+count);
    }
    public static bool IsPrime(int num)
    {

        if (num <= 1)
        {
            return false;
        }
        for (int i = 2; i <= Math.Sqrt(num); i++)
        {
            if (num % i == 0)
            {
                return false;
            }
        }
        return true;
        
    }
}