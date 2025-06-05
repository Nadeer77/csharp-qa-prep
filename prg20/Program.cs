        //Removing duplicates in an array

using System;
using System.Collections.Generic;
public class Program
{
    public static void Main(string[] args)
    {
        int[] arr = { 1, 2, 2, 3, 4, 4, 5 };
        HashSet<int> uniqueElements = new HashSet<int>();

        foreach (int num in arr)
        {
            uniqueElements.Add(num);
        }
        Console.WriteLine("After Removing Duplicates from array: ");
        foreach (int i in uniqueElements)
        {
            Console.WriteLine(i + " ");
        }
    }
}