//         //second largest number in an array

// using System;
// public class Solution
// {
//     public static void Main(string[] args)
//     {
//         int[] arr = { 1, 2, 3, 4, 5, 6 };
//         int largest = arr[0];
//         int seclargest = arr[1];
//         foreach (int num in arr)
//         {
//             if (num >= largest)
//             {
//                 seclargest = largest;
//                 largest = num;
//             }
//             else if (num > seclargest && num != largest)
//             {
//                 seclargest = num;
//             }
//         }
//         Console.WriteLine($"Second largest in an array is: {seclargest}");
//     }
// }

//         //second smallest number in an array


using System;

public class Solution
{
    public static void Main(string[] args)
    {
        int[] arr = { 1, 2, 3, 4, 5, 6 };

        if (arr.Length < 2)
        {
            Console.WriteLine("Array must have at least two elements.");
            return;
        }

        int smallest = int.MaxValue;
        int secSmallest = int.MaxValue;

        for (int i = 0; i < arr.Length; i++)
        {
            int num = arr[i];
            if (num < smallest)
            {
                secSmallest = smallest;
                smallest = num;
            }
            else if (num < secSmallest && num != smallest)
            {
                secSmallest = num;
            }
        }
        Console.WriteLine("Second smallest element: " + secSmallest);
    }
}
