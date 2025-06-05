        //Given string is palindrme or not

using System;

public class Solution
{
    public void Palindrome(char[] chars)
    {
        int start = 0;
        int end  = chars.Length-1;
        bool isPalindrome = true;
        while (start<end)
        {
            if(chars[start]!=chars[end])
            {
                isPalindrome = false;
                break;
            }
            start++;
            end--;
        }
        if(isPalindrome)
        {
            Console.WriteLine(" Palindrome");
        }
        else
        {
            Console.WriteLine(" Not a Palindrome");
        }
    }
}

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Type something :");
        string input = Console.ReadLine()!;
        input = input.ToLower();
        char[] result = input.ToCharArray();
        Solution sol = new Solution();
        sol.Palindrome(result);
    }
}