        //GameDevHQ unity basics- task 2(if,else,else if)

using System;

public class Player
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the Player Health: ");
        int playerHealth = Convert.ToInt32(Console.ReadLine()!);
        bool isAlive =false;
        if(playerHealth > 100)
        {
            Console.WriteLine("Invalid Health stat");
            return;
        }
        else if(playerHealth > 0 && playerHealth <= 100)
        {
            isAlive =true;
        }
        else
        {
            isAlive = false;
        }
        
        if(isAlive == true)
        {
            Console.WriteLine("Player is Alive");
        }
        else
        {
            Console.WriteLine("Player is Dead");
        }
    }
}