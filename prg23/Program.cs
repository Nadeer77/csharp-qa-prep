// Even and odd in an given array + count of even and odd numbers in an array

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
        int evenCount = 0;
        int oddCount = 0;

        foreach (int i in arr)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine("Even Number: " + i);
                evenCount++;
            }
            else
            {
                Console.WriteLine("Odd number: " + i);
                oddCount++;
            }
        }
        Console.WriteLine($"Even Count: {evenCount} ");    
        Console.WriteLine($"Odd Count: {oddCount} "); 
    }
}