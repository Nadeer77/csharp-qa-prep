        //Sum of array 

using System;
public class Solution
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the array size: ");
        int size = Convert.ToInt32(Console.ReadLine());

        int[] arr = new int[size];

        for (int i = 0; i <size; i++)
        {
            Console.Write($"Element{i + 1}: ");
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }
        int sum = 0;
        foreach (int i in arr)
        {
            sum += i;
        }
        Console.WriteLine("Sum of array is: " + sum);
    }
}