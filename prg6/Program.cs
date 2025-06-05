        //Sorting an array (either ascending(>) or descending) and reversing it

using System;

public class Solution
{
    public static void Main(string[] args)
    {
        int[] arr = { 1, 5, 2, 7, 6, 8, 3 };

        //sort first either ascending(>) or descending(<)
        for (int i = 0; i < arr.Length - 1; i++)
        {
            for (int j = 0; j < arr.Length - 1 - i; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }

        // reverse next
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

        //final output after sorting and reversing
        Console.WriteLine("output after sorting and reversing: ");
        foreach (int num in arr)
        {
            Console.WriteLine(num);
        }
    }
}