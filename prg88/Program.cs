        //Linear Search

using System;

public class Search
{
    public int Linear(int[] arr, int target)
    {
        for(int i=0;i<arr.Length;i++)
        {
            if(arr[i]==target)
            {
                return i;
            }
        }
        return -1;
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        int[] arr = {1,2,3,4,5,6,7};
        Search li = new Search();
        int result = li.Linear(arr,3);
        Console.WriteLine(result);
    }
}