        //Binary Search

using System;

public class Solution
{
    public static void Main(string[] args)
    {
        int[] arr= {1,2,3,4,5,6,7};
        int result= Binary(arr,5);
        Console.WriteLine(result);
    }
    public static int Binary(int[] arr,int target)
    {
        int low=0;
        int high=arr.Length-1;
        while(low<=high)
        {
            int mid=low+(high-low)/2;
            if(arr[mid]==target)
            {
                return mid;
            }
            else if(arr[mid]<target)
            {
                low=mid+1;
            }
            else
            {
                high=mid-1;
            }
        }
        return -1;
    }
}