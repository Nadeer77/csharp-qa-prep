        //Hybrid Inheritance example

using System;
class Person
{
    public void ShowDetails()
    {
        Console.WriteLine("Person details");
    }
}
class Student : Person
{
    public void Study()
    {
        Console.WriteLine("Studying");
    }
}
interface ISports
{
    void Play();
}
class Topper : Student, ISports
{
    public void Play()
    {
        Console.WriteLine("Playing sports");
    }
}
class Solution
{
    public static void Main(string[] args)
    {
        Topper top = new Topper();
        top.ShowDetails();
        top.Study();
        top.Play();
    }
}