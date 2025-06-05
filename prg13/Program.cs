        //No. of digits in a number

using System;
public class Solution
{
    public static void Main(string[] args)
    {
        int num = 123;
        int count = 0;
        if (num == 0)
        {
            count = 1;
        }
        else
        {
            while (num != 0)
            {
                num = num / 10;
                count++;
            }
        }
        Console.WriteLine(" No. of digits in a number : " + count);
    }
}