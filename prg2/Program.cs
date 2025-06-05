        // prime number code for number;

// using System;

// public class Solution
// {
//     public static void Main(string[] args)
//     {
//         int num = 10;
//         bool isPrime = false;
//         Console.Write($"Prime Numbers from 1 to {num} are :");

//         for (int i = 1; i <= num; i++)
//         {
//             isPrime = true;

//             if (i <= 1)
//             {
//                 continue;
//             }

//             for (int j = 2; j <= Math.Sqrt(i); j++)
//             {
//                 if (i % j == 0)
//                 {
//                     isPrime = false;
//                     break;
//                 }
//             }
//             if (isPrime)
//             {
//                 Console.Write(i+" ");
//             }
//         }
//     }
// }


        // prime number code for a given array 

using System;

public class Solution
{
    public static void Main()
    {
        int[] num = {1, 2, 4, 6, 8, 10, 27, 19};
        Console.Write($"Prime Numbers from the given array are :");
        foreach (int i in num)
        {
            if (IsPrime(i))
            {
                Console.Write(i+" ");
            }
        }
    }

    public static bool IsPrime(int number)
    {
        if (number <= 1)
            return false;

        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
                return false;
        }
        return true;
    }
}