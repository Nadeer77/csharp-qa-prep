//Data abstraction example using Abstract class

using System;
public abstract class Animal
{
    public abstract void MakeSound();
}
public class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Dog Barks");
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        Animal obj = new Dog();
        obj.MakeSound();
    }
}