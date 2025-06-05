        //Average of elements in an array

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
        int sum = 0;
        foreach (int i in arr)
        {
            sum += i;
        }
        int average = sum / arr.Length;
        Console.WriteLine("Sum of array: "+sum);
        Console.WriteLine("Average of array: "+average);
    }
}