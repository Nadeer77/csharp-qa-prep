        //Nested switc example

using System;
public class Program
{
    public static void Main()
    {
        Console.Write("Enter department (CSE/ECE): ");
        string dept = Console.ReadLine()!.ToUpper();

        Console.Write("Enter year (1/2): ");
        int year = Convert.ToInt32(Console.ReadLine()!);

        switch (dept)
        {
            case "CSE":
                switch (year)
                {
                    case 1:
                        Console.WriteLine("CSE - First Year");
                        break;
                    case 2:
                        Console.WriteLine("CSE - Second Year");
                        break;
                    default:
                        Console.WriteLine("Invalid year for CSE");
                        break;
                }
                break;

            case "ECE":
                switch (year)
                {
                    case 1:
                        Console.WriteLine("ECE - First Year");
                        break;
                    case 2:
                        Console.WriteLine("ECE - Second Year");
                        break;
                    default:
                        Console.WriteLine("Invalid year for ECE");
                        break;
                }
                break;
                
            default:
                Console.WriteLine("Invalid department");
                break;
        }
    }
}