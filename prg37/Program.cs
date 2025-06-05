// Running Sum of 1D Array (problem 1480 of leetcode)

using System;
public class Program
{
    public int[] RunningSum(int[] nums)
    {
        for (int i = 1; i < nums.Length; i++)
        {
            nums[i] += nums[i - 1];
        }
        return nums;
    }
}
public class Solution
{
    public static void Main(string[] args)
    {
        Program pro = new Program();
        int[] nums = { 3, 1, 2, 10, 1 };
        nums = pro.RunningSum(nums);
        
        Console.Write("Running Sum is : ");
        foreach (int i in nums)
        {
            Console.Write(i +" ");
        }
    }
}