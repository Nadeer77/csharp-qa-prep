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
public class Program
{
    public static void Main(string[] args)
    {
        Dog dog = new Dog();
        dog.Sound();
        dog.Bark();
        Cat cat = new Cat();
        cat.Meow();
        cat.Sound();
    }
}