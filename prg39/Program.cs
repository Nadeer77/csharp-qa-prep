//Richest Customer Wealth (problem 1672 of leetcode)

using System;
public class Solution
{
    public int MaximumWealth(int[][] accounts)
    {
        int maxwealth = 0;
        foreach (int[] customer in accounts)
        {
            int currentcustomerwealth = 0;
            foreach (int bank in customer)
            {
                currentcustomerwealth += bank;
            }
            maxwealth = Math.Max(maxwealth, currentcustomerwealth);
        }
        return maxwealth;
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        Solution sol = new Solution();
        int[][] accounts = [[1, 2, 3], [3, 2, 1]];
        int result = sol.MaximumWealth(accounts);
        Console.WriteLine(result);
    }
}