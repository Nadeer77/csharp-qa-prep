        // Enum problem example - Months

using System;

public class Solution
{
    enum Month
    {
        January = 1,
        February,
        March,
        April,
        May,
        June,
        July,
        August,
        September,
        October,
        November,
        December
    }

    public static void Main(string[] args)
    {
        Month thisMonth = Month.February;
        Console.WriteLine("This Month is : " + thisMonth);
        Console.WriteLine("Month Number is : " + (int)thisMonth);
        Console.WriteLine("\nMonth : Month Number");

        // foreach loop
        foreach (Month m in Enum.GetValues(typeof(Month)))
        {
            Console.WriteLine($"{m} : {(int)m}");
        }
        Console.WriteLine();
        // for loop
        Array months = Enum.GetValues(typeof(Month));
        for (int i = 0; i < months.Length; i++)
        {
            Month m = (Month)months.GetValue(i)!;
            Console.WriteLine($"{m} : {(int)m}");
        }
        Console.WriteLine();
        // while loop
        int k = 0;
        while (k < months.Length)
        {
            Month m = (Month)months.GetValue(k)!;
            Console.WriteLine($"{m} : {(int)m}");
            k++;
        }
    }
}