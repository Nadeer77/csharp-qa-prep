//         //Move zeroes problem
//         // one apppraoch : using a new array for storing the resultant array after swap

// using System;

// public class Solution
// {
//     public int[] MoveZeroes (int[] nums)
//     {
//         int j=0;
//         for (int i = 0; i < nums.Length; i++)
//         {
//             if (nums[i] != 0)
//             {
//                 int temp = nums[i];
//                 nums[i] = nums[j];
//                 nums[j] = temp;
//                 j++;
//             }
//         }
//         return nums;
//     }
// }

// public class HelloWorld
// {
//     public static void Main(string[] args)
//     {
//         Solution sol = new Solution();
//         int[] nums = { 1, 0, 2, 0, 4, 0, 5 };
//         int[] result = sol.MoveZeroes(nums);
//         Console.WriteLine("After moving Zeroes:");
//         foreach (int num in result)
//         {
//             Console.WriteLine(num);
//         }

//     }
// }


//         // another approach : storing in the same array after swap


// using System;

// public class Solution
// {
//     public void MoveZeroes (int[] nums)
//     {
//         int j=0;
//         for(int i=0;i<nums.Length;i++)
//         {
//             if(nums[i]!=0)
//            {
//                int temp=nums[i];
//                nums[i]=nums[j];
//                nums[j]=temp;
//                j++;
//            }
//         }
//     }
// }

// public class HelloWorld
// {
//     public static void Main(string[] args)
//     {
//         Solution sol = new Solution();
//         int[] nums = { 1, 0, 2, 0, 4, 0, 5 };
//         sol.MoveZeroes(nums);
//         Console.WriteLine("After moving Zeroes:");
//         foreach (int num in nums)
//         {
//             Console.WriteLine(num);
//         }
//     }
// } 

        // Move zeroes using while loop

using System;
public class Solution
{
    public void MoveZeroes(int[] arr)
    {
        int j=0;
        int i=0;
        while(i<arr.Length)
        {
            if(arr[i]!=0)
            {
                int temp = arr[i];
                arr[i]=arr[j];
                arr[j]=temp;
                j++;
            }
            i++;
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the size:");
        int size = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[size];
        Console.WriteLine("BEFORE MOVING ZEROES:");
        for (int i = 0; i < size; i++)
        {
            Console.Write($"Element {i + 1} : ");
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        Solution sol = new Solution();
        sol.MoveZeroes(arr);
        Console.WriteLine("\nAFTER MOVING ZEROES:");
        int k = 0;
        while (k < arr.Length)
        {
            Console.Write($"\nElement {k + 1} : ");
            Console.Write(arr[k] + " ");
            k++;
        }
    }
}