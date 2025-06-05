// Fizz-Buzz Problem (problem 412 of leetcode)

using System;
using System.Collections.Generic;
public class Program
{
    public IList<string> FizzBuzz(int n) {
        List<string> answer = new List<string>(n);
        for(int i=1;i<=n;i++)
        {
            bool divisibleby3 = i % 3 == 0;
            bool divisibleby5 = i % 5 == 0;
            if(divisibleby5 && divisibleby3)
            {
                answer.Add("FizzBuzz");
            }
            else if(divisibleby3)
            {
                answer.Add("Fizz");
            }
            else if(divisibleby5)
            {
                answer.Add("Buzz");
            }
            else
            {
                answer.Add(i.ToString());
            }
        }
        return answer;
    }
}
public class Solution
{
    public static void Main(string[] args)
    {
        Program pro = new Program();
        int n = 5;
        IList<string> answer = pro.FizzBuzz(n);
        foreach (string i in answer)
        {
            Console.WriteLine(i);
        }
    }
}