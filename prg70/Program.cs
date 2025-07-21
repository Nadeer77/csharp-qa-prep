        //Simple Async program

using System;
using System.Threading.Tasks;

class Solution
{
    static async Task Main()
    {
        Console.WriteLine("Start");
        await DoSomethingAsync();
        Console.WriteLine("End");
    }
    static async Task DoSomethingAsync()
    {
        Console.WriteLine("Do something...");
        await Task.Delay(2000);
        Console.WriteLine("Finished Doing!!");
    }
}