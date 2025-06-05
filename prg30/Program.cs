// find the first non-repeating character in a string (like w in 'swiss' or like h in 'hello' )

using System;
public class Solution
{
    public static char FirstNonRepeatingChar(string input)
    {
        Dictionary<char, int> charCount = new Dictionary<char, int>();
        foreach (char c in input)
        {
            if (charCount.ContainsKey(c))
            {
                charCount[c]++;
            }
            else
            {
                charCount[c] = 1;
            }
        }
        foreach (char c in input)
        {
            if (charCount[c] == 1)
            {
                return c;
            }
        }
        return '\0';

    }
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a string: ");
        string input = Console.ReadLine()!;

        char result = FirstNonRepeatingChar(input);
        if (result != '\0')
        {
            Console.WriteLine("first non-repeating character: " + result);
        }
        else
        {
            Console.WriteLine("There are no non-repeating character");
        }
        
    }
}