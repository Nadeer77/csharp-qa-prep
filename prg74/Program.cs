        // IEnumertor and IEnumerable example

using System;
using System.Collections;
using System.Collections.Generic;
public class MyCollection : IEnumerable
{
    private int[] numbers = { 1, 2, 3 };
    public IEnumerator GetEnumerator()
    {
        return numbers.GetEnumerator();  
    }
}
class Program
{
    static void Main()
    {
        MyCollection collection = new MyCollection();
        foreach (int number in collection)
        {
            Console.WriteLine(number);  // Output: 1 2 3
        }
    }
}