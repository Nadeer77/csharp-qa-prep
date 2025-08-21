        // IEnumertor and IEnumerable example using fruits(string)

using System;
using System.Collections;

public class Fruits : IEnumerable
{
    string[] fruitList = { "Apple", "Banana", "Cherry" };
    
    public IEnumerator GetEnumerator()
    {
        return fruitList.GetEnumerator();
    }
}

class Program
{
    static void Main()
    {
        Fruits fruits = new Fruits();

        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);  
        }
    }
}
