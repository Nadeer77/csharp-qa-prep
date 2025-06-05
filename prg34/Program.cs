        //Missing number program

using System;
public class Solution
{
    public static int FindMissingNumber(int[] num)
    {
        int n = num.Length + 1;
        int totalSum = n * (n + 1) / 2;
        int numSum = 0;
        foreach (int arr in num)
        {
            numSum += arr;
        }
        return totalSum - numSum;
    }
    public static void Main(string[] args)
    {
        int[] num = { 1, 2, 4, 5, 6 };
        int missingNumber = FindMissingNumber(num);
        Console.WriteLine("Missing number is: " + missingNumber);
    }
}