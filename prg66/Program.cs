        //GameDevHQ unity basics- task 1(Variables)

using System;

public class Player
{
    public string name = "Nadeer";
    public  int age =23;
    public string gender = "male";
    public string location = "Kasaragod";
    public static void Main(string[] args)
    {
        Player p = new Player();
        Console.WriteLine(p.name);
        Console.WriteLine(p.age);
        Console.WriteLine(p.gender);
        Console.WriteLine(p.location);
    }
}