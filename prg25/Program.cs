        //Rotate an Array by K Positions

using System;
public class Solution
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the array size: ");
        int size = int.Parse(Console.ReadLine()!);

        int[] arr = new int[size];
        for (int i = 0; i < size; i++)
        {
            Console.WriteLine($"Element {i + 1}");
            arr[i] = int.Parse(Console.ReadLine()!);
        }
        Console.WriteLine("Enter the number of rotation: ");
        int k = int.Parse(Console.ReadLine()!);

        // Handle cases where k > size
        k = k % size;

        int[] rotated = new int[size];

        for (int i = 0; i < size; i++)
        {
            int newIndex = (i + k) % size;
            rotated[newIndex] = arr[i];
        }
        Console.Write("Array after Rotation: ");
        foreach (int i in rotated)
        {
            Console.Write(i + " ");
        }
    }
}