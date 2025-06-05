//method overriding example

using System;
public class Animal
{
    public virtual void Sound()
    {
        Console.WriteLine("Animal is making Sound");
    }
}
public class Dog : Animal
{
    public override void Sound()
    {
        Console.WriteLine("Dog is Barking");
    }
}

public class Solution
{
    public static void Main(string[] args)
    {
        Animal obj = new Dog();
        obj.Sound();
    }
}