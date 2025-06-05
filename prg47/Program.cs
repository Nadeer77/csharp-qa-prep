using System;
public class Solution
{
    public static void Main(string[] args)
    {
        int[] arr = { 1, 2, 3, 4, 5 };
        for (int i = arr.Length-1; i>=0; i--)
        {
            Console.Write(arr[i]+" ");
        }
    }
}