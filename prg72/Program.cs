using System;
using System.Threading;
class Solution
{
    static void PrintNumbers()
    {
          for(int i=0;i<5;i++)
          {
              Console.WriteLine(i);
              Thread.Sleep(1000);
          }
    }
    static void Main()
    {
        Thread thread = new Thread(PrintNumbers);
        thread.Start();
        Console.WriteLine("Main Thread Continues");
    }
}