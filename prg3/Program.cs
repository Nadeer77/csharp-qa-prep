        //Move zeroes problem
        // one apppraoch : using a new array for storing the resultant array after swap

using System;

public class Solution
{
    public int[] MoveZeroes (int[] nums)
    {
        int j=0;
        for(int i=0;i<nums.Length;i++)
        {
            if(nums[i]!=0)
           {
               int temp=nums[i];
               nums[i]=nums[j];
               nums[j]=temp;
               j++;
           }
        }
        return nums;
    }
}

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Solution sol = new Solution();
        int[] nums = { 1, 0, 2, 0, 4, 0, 5 };
        int[] result = sol.MoveZeroes(nums);
        Console.WriteLine("After moving Zeroes:");
        foreach (int num in result)
        {
            Console.WriteLine(num);
        }

    }
}


        // another approach : storing in the same array after swap


using System;

public class Solution
{
    public void MoveZeroes (int[] nums)
    {
        int j=0;
        for(int i=0;i<nums.Length;i++)
        {
            if(nums[i]!=0)
           {
               int temp=nums[i];
               nums[i]=nums[j];
               nums[j]=temp;
               j++;
           }
        }
    }
}

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Solution sol = new Solution();
        int[] nums = { 1, 0, 2, 0, 4, 0, 5 };
        sol.MoveZeroes(nums);
        Console.WriteLine("After moving Zeroes:");
        foreach (int num in nums)
        {
            Console.WriteLine(num);
        }
    }
} 