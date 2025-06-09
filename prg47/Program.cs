//Reverse an array using for loop(not actualling reversing, just printing it in reverse order)

using System;
public class Solution
{
    public static void Main(string[] args)
    {
        int[] arr = { 1, 2, 3, 4, 5 };
        for (int i = arr.Length - 1; i >= 0; i--)
        {
            Console.Write(arr[i] + " ");
        }
    }
}

//Reverse an array using for loop(actualling reversing)


using System;
public class Solution
{
    public static void Main(string[] args)
    {
        int[] arr = { 1, 2, 3, 4, 5 };
        int n = arr.Length;
        for (int i = 0; i < n / 2; i++)
        {
            int temp = arr[i];
            arr[i] = arr[n - 1 - i];
            arr[n - 1 - i] = temp;
        }
        foreach (int i in arr)
        {
            Console.Write(i + " ");
        }
    }
}

        //while loop approach for reverse 

using System;
public class Solution
{
    public static void Main(string[] args)
    {
        int[] arr = { 1, 2, 3, 4, 5 };
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
        foreach (int i in arr)
        {
            Console.Write(i + " ");
        }
    }
}

        //both while loop approach for reverse and printing


using System;
public class Solution
{
    public static void Main(string[] args)
    {
        int[] arr = { 1, 2, 3, 4, 5 };
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
        int i = 0;
        while (i < arr.Length)
        {
            Console.Write(arr[i] + " ");
            i++;
        }
    }
}


        //both for loop approach for reverse and printing


using System;
public class Solution
{
    public static void Main(string[] args)
    {
        int[] arr = { 1, 2, 3, 4, 5 };
        int n = arr.Length;
        for (int i = 0; i < n / 2; i++)
        {
            int temp = arr[i];
            arr[i] = arr[n - 1 - i];
            arr[n - 1 - i] = temp;
        }
        for (int i = 0; i < n; i++)
        {
            Console.Write(arr[i] + " ");
        }
    }
}