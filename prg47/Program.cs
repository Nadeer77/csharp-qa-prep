//Reverse an array using for loop(not actualling reversing, just printing it in reverse order)

// using System;
// public class Solution
// {
//     public static void Main(string[] args)
//     {
//         int[] arr = { 1, 2, 3, 4, 5 };
//         for (int i = arr.Length - 1; i >= 0; i--)
//         {
//             Console.Write(arr[i] + " ");
//         }
//     }
// }

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