        // check whether the given two strings are anagrams (listen ~ silent)

using System;
public class Solution
{
    public static bool AreAnagrams(string str1, string str2)
    {
        str1 = str1.Replace(" ", "").ToLower();
        str2 = str2.Replace(" ", "").ToLower();

        if (str1.Length != str2.Length)
        {
            return false;
        }

        char[] arr1 = str1.ToCharArray();
        char[] arr2 = str2.ToCharArray();
        Array.Sort(arr1);
        Array.Sort(arr2);

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
        Console.WriteLine("Enter first string:");
        string input1 = Console.ReadLine()!;

        Console.WriteLine("Enter second string:");
        string input2 = Console.ReadLine()!;

        if (AreAnagrams(input1, input2))
        {
            Console.WriteLine("Yes, they are anagrams");
        }
        else
        {
            Console.WriteLine("No, they are not anagrams");
        }
    }
}