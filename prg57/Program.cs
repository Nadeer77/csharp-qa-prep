        //Switch case for choosing options (1,2,3,...)

using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter a number (1 to 3): ");
        int choice = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.WriteLine("You chose One");
                break;

            case 2:
                Console.WriteLine("You chose Two");
                break;

            case 3:
                Console.WriteLine("You chose Three");
                break;

            default:
                Console.WriteLine("Invalid choice");
                break;
        }
    }
}