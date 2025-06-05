// Number of Steps to Reduce a Number to Zero (problem 1672 of leetcode)

using System;
public class Solution
{
    public int NumberOfSteps(int num)
    {
        int step = 0;
        while (num != 0)
        {
            if (num % 2 == 0)
            {
                num /= 2;
            }
            else if (num % 2 != 0)
            {
                num -= 1;
            }
            step++;
        }
        return step;
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        Solution sol = new Solution();
        int num = 14;
        int stepscount = sol.NumberOfSteps(num);
        Console.WriteLine("Steps: " + stepscount);
    }
}