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
        int n = arr.Length;
        for (int i = 0; i < n/2; i++)
        {
            int temp = arr[i];
            arr[i] = arr[n - 1 - i];
            arr[n - 1 - i] = temp;
        }
        Console.Write("Reversed Array: ");
        foreach (int i in arr)
        {
            Console.Write(i+ " ");
        }
    }
}