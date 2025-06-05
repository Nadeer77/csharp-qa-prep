        //finding the second largest word in a string

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