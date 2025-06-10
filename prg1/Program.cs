        //finding the second largest word in a stringusing foreach loop

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        string sentence = "my name is nadeer";
        string[] words = sentence.Split(' ');

        string largestword = "";
        string secondlargestword = "";

        foreach (string word in words)
        {
            if (word.Length >= largestword.Length)
            {
                secondlargestword = largestword;
                largestword = word;
            }
            else if (word.Length > secondlargestword.Length && word != largestword)
            {
                secondlargestword = word;
            }
        }
        Console.WriteLine($"Second Largest word: {secondlargestword}");
    }
}

        // finding the second largest word in a string using for loop

using System;
public class Solution
{
    public static void Main(string[] args)
    {
        string sentence = "my name is nadeer";
        string[] words = sentence.Split(' ');

        string largest = "";
        string secondlargest = "";
        for (int i = 0; i < words.Length; i++)
        {
            string word = words[i];
            if (word.Length >= largest.Length)
            {
                secondlargest = largest;
                largest = word;
            }
            else if (word.Length > secondlargest.Length && word != largest)
            {
                secondlargest = word;
            }
        }
        Console.WriteLine($"Second Largest word: {secondlargest}");
    }
}

        //finding the second largest word in a string using while loop

using System;

public class Program
{
    public static void Main(string[] args)
    {
        string sentence = "my name is nadeer";
        string[] words = sentence.Split(' ');

        string largest = "";
        string secondlargest = "";

        int i = 0;
        while (i < words.Length)
        {
            string word = words[i];

            if (word.Length >= largest.Length)
            {
                secondlargest = largest;
                largest = word;
            }
            else if (word.Length > secondlargest.Length && word != largest)
            {
                secondlargest = word;
            }
            i++;
        }
        Console.WriteLine($"Second Largest word: {secondlargest}");
    }
}