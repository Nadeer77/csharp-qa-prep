        // Async programming example returning a value

using System;
using System.Threading.Tasks;

class Solution
{
    static async Task Main()
    {
        Console.WriteLine("In Main");
        int result = await asyncsum(5,10);
        Console.WriteLine("Returned to Main");
        await Task.Delay(3000);
        Console.WriteLine(result);
        Console.WriteLine("Done calculating sum and printed it");
    }
    static async Task<int> asyncsum(int a,int b)
    {
        Console.WriteLine("In asyncsum");
        await Task.Delay(3000);
        Console.WriteLine("Returning to Main");
        return a+b;
    }
}