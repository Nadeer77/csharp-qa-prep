        // Vowel and Consonant count

using System;
public class Solution
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the string: ");
        string input = Console.ReadLine()!;
        input = input.ToLower();

        int vowels = 0;
        int consonants = 0;

        foreach (char ch in input)
        {
            if (char.IsLetter(ch))
            {
                if ("aeiou".Contains(ch))
                {
                    vowels++;
                }
                else
                {
                    consonants++;
                }
            }
        }
        Console.WriteLine($"Vowel count : {vowels}");
        Console.WriteLine($"Consonant count : {consonants}");
    }
}