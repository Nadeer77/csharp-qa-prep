        // Enum problem example -Days

using System;
public class Solution
{
    enum Day
    {
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
    }

    public static void Main(string[] args)
    {
        Day today = Day.Sunday;
        Console.WriteLine("Today is : " + today);
        Console.WriteLine("Day Number is : " + (int)today);
        Console.WriteLine("\nDay : Day Number");

        //foreach approach

        foreach (Day d in Enum.GetValues(typeof(Day)))
        {
            Console.WriteLine($"{d} : {(int) d}");
        }

        //for loop approach

        Array days = Enum.GetValues(typeof(Day));
        for (int i = 0; i < days.Length; i++)
        {
            Day d = (Day)days.GetValue(i);
            Console.WriteLine($"{d} : {(int) d}");
        }

        //while loop approach

        Array days = Enum.GetValues(typeof(Day));
        int i = 0;
        while (i < days.Length)
        {
            Day d = (Day)days.GetValue(i);
            Console.WriteLine($"{d} : {(int)d}");
            i++;
        }
    }
}