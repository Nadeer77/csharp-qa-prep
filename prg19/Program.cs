        //vowel count

using System;
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a string: ");
        string input = Console.ReadLine()!;

        if (string.IsNullOrEmpty(input))
        {
            Console.WriteLine("No input given");
            return;
        }
        int vowelcount = 0;
        string vowels = "aeiouAEIOU";

        foreach (char c in input)
        {
            if (vowels.Contains(c))
            {
                vowelcount++;
            }
        }
        Console.WriteLine("Vowel count : " + vowelcount);

    }
}