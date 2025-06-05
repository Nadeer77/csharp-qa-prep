        //largest number in an array

using System;
public class Solution
{
    public static void Main(string[] args)
    {
        int[] arr = { 1, 2, 3, 4, 5, 6 };
        int largest = arr[0];
        foreach (int num in arr)
        {
            if (num > largest)
            {
                largest = num;
            }
        }
        Console.WriteLine($"largest in an array is: {largest}");
    }
}

        //smallest number in an array

using System;
public class Solution
{
    public static void Main(string[] args)
    {
        int[] arr = { 1, 2, 3, 4, 5, 6 };
        int smallest = arr[0];
        foreach (int num in arr)
        {
            if (num < smallest)
            {
                smallest = num;
            }
        }
        Console.WriteLine($"largest in an array is: {smallest}");
    }
}