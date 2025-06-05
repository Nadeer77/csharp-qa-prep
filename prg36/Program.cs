        //Ransom Note (problem 383 of leetcode)

using System;
using System.Collections.Generic;

public class Solution
{
    public static bool CanConstruct(string ransomNote, string magazine)
    {
        Dictionary<char, int> letterCount = new Dictionary<char, int>();

        foreach (char c in magazine)
        {
            if (letterCount.ContainsKey(c))
                letterCount[c]++;
            else
                letterCount[c] = 1;
        }

        foreach (char c in ransomNote)
        {
            if (!letterCount.ContainsKey(c) || letterCount[c] == 0)
                return false;
            
            letterCount[c]--;
        }

        return true;
    }
    public static void Main()
    {
        Solution sol = new Solution();
        Console.WriteLine("Enter the ransomnote : ");
        string ransomNote = Console.ReadLine()!;
        Console.WriteLine("Enter the magazine : ");
        string magazine = Console.ReadLine()!;

        Console.WriteLine(CanConstruct(ransomNote, magazine));
    }
}
