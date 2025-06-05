        // code for ascending of array values

using System;

public class Solution
{
    public static void Main(string[] args)
    {
        int[] arr = { 1, 5, 2, 7, 6, 8, 3 };

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
        foreach (int num in arr)
        {
            Console.WriteLine(num);
        }
    }
}


        // code for descending of array values

using System;

public class Solution
{
    public static void Main(string[] args)
    {
        int[] arr = { 1, 5, 2, 7, 6, 8, 3 };

        for (int i = 0; i < arr.Length - 1; i++)
        {
            for (int j = 0; j < arr.Length - 1 - i; j++)
            {
                if (arr[j] < arr[j + 1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
        foreach (int num in arr)
        {
            Console.WriteLine(num);
        }
    }
}