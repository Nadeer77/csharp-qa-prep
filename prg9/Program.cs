//         //factorial program using loop 

// using System;
// public class Solution
// {
//     public static void Main(string[] args)
//     {
//         Console.WriteLine("Write a number: ");
//         int num = 5;
//         int fact = 1;

//         for (int i = 1; i <= num; i++)
//         {
//             fact *= i;
//         }
//         Console.WriteLine($"factorial of {num} is : {fact} ");
//     }
// }


//         //factorial program using Recursion

// using System;
// public class Solution
// {
//     public static long Factorial(int num)
//     {
//         if (num <= 1)
//             return 1;
//         return num * Factorial(num - 1);
//     }
// }
// public class Test
// {
//     public static void Main(string[] args)
//     {
//         int n = 5;
//         long result = Solution.Factorial(n);
//         Console.WriteLine($"factorial of {n} is : {result} ");
//     }
// }
using System;
public class Solution
{
    public static long Factorial(int num)
    {
        if (num <= 1)
            return 1;
        return num * Factorial(num - 1);
    }
    public static void Main(string[] args)
    {
        int n = 5;
        long result = Factorial(n);
        Console.WriteLine($"factorial of {n} is : {result} ");
    }
}