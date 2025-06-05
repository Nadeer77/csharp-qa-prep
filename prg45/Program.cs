        //Even number printing using for loop

using System;
public class Solution
{
    public static void Main(string[] args)
    {

        for (int i = 1; i <= 10; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine("Even number : " + i);
            }
        }
    }
}

//Even number printing using while loop

using System;
public class Solution
{
    public static void Main(string[] args)
    {
        int num = 10;
        int i = 1;
        while (i <= num)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
            }
            i++;
        }
    }
}