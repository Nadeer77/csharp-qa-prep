        //frequency of a value/digit(how many times a number appeared)

using System;
public class Solution
{
    public static void Main(string[] args)
    {
        int[] arr = { 1, 2, 3, 4, 5, 2, 4 };
        Dictionary<int, int> freq = new Dictionary<int, int>();

        foreach (int num in arr)
        {
            if (freq.ContainsKey(num))
            {
                freq[num]++;
            }
            else
            {
                freq[num] = 1;
            }
        }
        Console.WriteLine("Element Frequencies: ");
        foreach (var pair in freq)
        {
            Console.WriteLine($"{pair.Key} -> {pair.Value} time{(pair.Value > 1 ? "s" : "")}");
        }
    }
}
