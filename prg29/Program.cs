        //to reverse each word in a sentence while maintaining word order (eg: Hello World ~ olleH dlroW)

using System;
public class Solution
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the string: ");
        string input = Console.ReadLine();

        string[] words = input.Split(' ');

        for (int i = 0; i < words.Length; i++)
        {
            char[] chars = words[i].ToCharArray();
            Array.Reverse(chars);
            words[i] = new string(chars);
        }
        string result = string.Join(" ", words);
        Console.WriteLine("Reversed words: "+result);
    }
}