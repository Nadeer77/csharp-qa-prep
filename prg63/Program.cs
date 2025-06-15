        // Enum problem example - Planets

using System;

public class Solution
{
    enum Planet
    {
        Mercury,
        Venus,
        Earth,
        Mars,
        Jupiter,
        Saturn,
        Uranus,
        Neptune
    }

    public static void Main(string[] args)
    {
        Planet myPlanet = Planet.Earth;
        Console.WriteLine("My Planet is : " + myPlanet);
        Console.WriteLine("Planet Number is : " + (int)myPlanet);
        Console.WriteLine("\nPlanet : Planet Number");

        // foreach loop
        foreach (Planet p in Enum.GetValues(typeof(Planet)))
        {
            Console.WriteLine($"{p} : {(int)p}");
        }
        Console.WriteLine();
        // for loop
        Array planets = Enum.GetValues(typeof(Planet));
        for (int i = 0; i < planets.Length; i++)
        {
            Planet p = (Planet)planets.GetValue(i)!;
            Console.WriteLine($"{p} : {(int)p}");
        }
        Console.WriteLine();
        // while loop
        int j = 0;
        while (j < planets.Length)
        {
            Planet p = (Planet)planets.GetValue(j)!;
            Console.WriteLine($"{p} : {(int)p}");
            j++;
        }
    }
}
