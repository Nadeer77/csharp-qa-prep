        //Inheritance example 

using System;
public class Animal
{
    public void Sound()
    {
        Console.WriteLine("Animal making sound");
    }
}
public class Cat : Animal
{
    public void Meow()
    {
        Console.WriteLine("Cat is meowing");
    }
}
public class Dog : Animal
{
    public void Bark()
    {
        Console.WriteLine("Dog is barking");
    }
}
public class Puppy : Dog
{
    public void Bow()
    {
        Console.WriteLine("Puppy is Bowing");
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        Dog dog = new Dog();
        dog.Sound();
        dog.Bark();

        Console.WriteLine();

        Cat cat = new Cat();
        cat.Sound();
        cat.Meow();

        Console.WriteLine();

        Puppy puppy = new Puppy();
        puppy.Sound();
        puppy.Bark();
        puppy.Bow();
    }
}