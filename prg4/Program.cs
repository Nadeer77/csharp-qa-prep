        //Reversing an array

using System;

public class Solution
{
    public static void Main()
    {
        int[] arr = { 1, 5, 2, 7, 6, 8, 3 };

        int start = 0;
        int end = arr.Length - 1;
        while (start < end)
        {
            int temp = arr[start];
            arr[start] = arr[end];
            arr[end] = temp;
            start++;
            end--;
        }
        Console.WriteLine("Reversed array: ");
        foreach (int num in arr)
        {
            Console.WriteLine(num);
        }
    }
}



using System;
public class Solution
{
    public static void Main(string[] args)
    {
        int[] arr = { 1, 5, 2, 7, 6, 8, 3 };
        int start = 0;
        int end = arr.Length-1;
        while (start < end)
        {
            int temp = arr[start];
            arr[start] = arr[end];
            arr[end] = temp;
            start++;
            end--;
        }
        Console.Write("Reversed Array: ");
        foreach (int i in arr)
        {
            Console.Write(i+ " ");
        }
    }
}