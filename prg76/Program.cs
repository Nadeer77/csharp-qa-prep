        // Array

using System;

class ArrayOps
{
    public static void Print(int[] arr, int size)
    {
        Console.Write("Array: ");
        for (int i = 0; i < size; i++)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();
    }

    public static int Insert(int[] arr, int size, int element, int position)
    {
        if (position < 0 || position > size)
        {
            Console.WriteLine("Invalid position!");
            return size;
        }

        for (int i = size; i > position; i--)
        {
            arr[i] = arr[i - 1]; // shift right
        }
        arr[position] = element;
        return size + 1;
    }

    public static int Delete(int[] arr, int size, int position)
    {
        if (position < 0 || position >= size)
        {
            Console.WriteLine("Invalid position!");
            return size;
        }

        for (int i = position; i < size - 1; i++)
        {
            arr[i] = arr[i + 1]; // shift left
        }
        return size - 1;
    }

    public static void Hide(int[] arr, int size, int position)
    {
        if (position < 0 || position >= size)
        {
            Console.WriteLine("Invalid position!");
            return;
        }
        arr[position] = -1; // mark hidden
    }

    public static void Replace(int[] arr, int size, int position, int newValue)
    {
        if (position < 0 || position >= size)
        {
            Console.WriteLine("Invalid position!");
            return;
        }
        arr[position] = newValue;
    }

    public static void Search(int[] arr, int size, int value)
    {
        bool found = false;
        for (int i = 0; i < size; i++)
        {
            if (arr[i] == value)
            {
                Console.WriteLine($"Value {value} found at position {i}");
                found = true;
            }
        }
        if (!found)
        {
            Console.WriteLine($"Value {value} not found in array.");
        }
    }
}
class Solution
{
    static void Main()
    {
        int[] arr = new int[20];
        int size = 5;

        arr[0] = 10;
        arr[1] = 20;
        arr[2] = 30;
        arr[3] = 40;
        arr[4] = 50;

        Console.WriteLine("Initial Array:");
        ArrayOps.Print(arr, size);

        size = ArrayOps.Insert(arr, size, 25, 2);
        Console.WriteLine("\nAfter Insertion:");
        ArrayOps.Print(arr, size);

        size = ArrayOps.Delete(arr, size, 3);
        Console.WriteLine("\nAfter Deletion:");
        ArrayOps.Print(arr, size);

        ArrayOps.Hide(arr, size, 1);
        Console.WriteLine("\nAfter Hiding:");
        ArrayOps.Print(arr, size);

        ArrayOps.Replace(arr, size, 0, 99);
        Console.WriteLine("\nAfter Replacing:");
        ArrayOps.Print(arr, size);

        Console.WriteLine("\nSearching for 40 and 100:");
        ArrayOps.Search(arr, size, 40);
        ArrayOps.Search(arr, size, 100);
    }
}
