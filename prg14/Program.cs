        //second largest number in an array

using System;
public class Solution
{
    public static void Main(string[] args)
    {
        int[] arr = { 1, 2, 3, 4, 5, 6 };
        int largest = arr[0];
        int seclargest = arr[1];
        foreach (int num in arr)
        {
            if (num > largest)
            {
                seclargest = largest;
                largest = num;
            }
            else if (num > seclargest && num != largest)
            {
                seclargest = num;
            }
        }
        Console.WriteLine($"Second largest in an array is: {seclargest}");
    }
}

        //second smallest number in an array


using System;
public class Solution
{
    public static void Main(String[] args)
    {
        int[] arr = { 1, 2, 3, 4, 5, 6 };
        int smallest = arr[0];
        int secsmallest = arr[1];
        foreach (int num in arr)
        {
            if (num < smallest)
            {
                secsmallest = smallest;
                smallest = num;
            }
            else if (num < secsmallest && num != smallest)
            {
                secsmallest = num;
            }
        }
        Console.WriteLine("Second smallest ele : "+secsmallest);
    }
}