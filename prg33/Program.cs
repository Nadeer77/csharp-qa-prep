        //Given two arrays are equal or not 

using System;
public class Solution
{
    public static bool AreArraysEqual(int[] arr1, int[] arr2)
    {
        if (arr1.Length != arr2.Length)
        {
            return false;
        }
        for (int i = 0; i < arr1.Length; i++)
        {
            if (arr1[i] != arr2[i])
            {
                return false;
            }
        }
        return true;
    }
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter size of arrays:");
        int size = int.Parse(Console.ReadLine()!);

        int[] arr1 = new int[size];
        int[] arr2 = new int[size];

        Console.WriteLine("Enter elements for Array 1:");
        for (int i = 0; i < size; i++)
        {
            arr1[i] = int.Parse(Console.ReadLine()!);
        }

        Console.WriteLine("Enter elements for Array 2:");
        for (int i = 0; i < size; i++)
        {
            arr2[i] = int.Parse(Console.ReadLine()!);
        }

        bool result = AreArraysEqual(arr1, arr2);

        if (result)
        {
            Console.WriteLine("Arrays are equal");
        }
        else
        {
            Console.WriteLine("Arrays are not equal");
        }  
    }
}