        // Multiple Inheritance Example

using System;
interface ITalk
{
    void Talk();
}
interface IWalk
{
    void Walk();
}
public class Person : ITalk, IWalk
{
    public void Talk()
    {
        Console.WriteLine("Person is Talking");
    }
    public void Walk()
    {
        Console.WriteLine("Person is Walking");
    }
}
public class Solution
{
    public static void Main(string[] args)
    {
        Person p = new Person();
        p.Talk();
        p.Walk();
    }
}