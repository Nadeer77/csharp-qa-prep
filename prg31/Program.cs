        // second smallest number in an array

using System;

public class Solution
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter array size:");
        int size = int.Parse(Console.ReadLine()!);

        if (size == 0 || size == 1 )
        {
            return;
        }

        int[] arr = new int[size];

        Console.WriteLine("Enter array elements:");
        for (int i = 0; i < size; i++)
        {
            arr[i] = int.Parse(Console.ReadLine()!);
        }

        int smallest = arr[size-1];
        int secondSmallest = arr[size-2];

        foreach (int num in arr)
        {
            if (num < smallest)
            {
                secondSmallest = smallest;
                smallest = num;
            }
            else if (num < secondSmallest && num != smallest)
            {
                secondSmallest = num;
            }
        }
        Console.WriteLine("Second smallest number is: " + secondSmallest);   
    }
}
