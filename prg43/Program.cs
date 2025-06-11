        //Data Encapsulation example

using System;
public class Person
{
    private string name = "";
    public void SetName(string newname)
    {
        name = newname;
    }
    public string GetName()
    {
        return name;
    }
}
public class Solution
{
    public static void Main(string[] args)
    {
        Person person = new Person();
        person.SetName("Nadeer");
        Console.WriteLine(person.GetName());
    }
}