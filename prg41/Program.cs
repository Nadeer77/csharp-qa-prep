        // Middle of the Linked List(problem 876 of leetcode) 
        //print middle number only

#nullable enable
using System;

public class ListNode
{
    public int val;
    public ListNode? next; // Nullable
    public ListNode(int val = 0, ListNode? next = null)
    {
        this.val = val;
        this.next = next;
    }
}

public class Solution
{
    public ListNode MiddleNode(ListNode head)
    {
        ListNode? slow = head;
        ListNode? fast = head;

        while (fast != null && fast.next != null)
        {
            slow = slow!.next!;
            fast = fast.next!.next!;
        }

        return slow!;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        // 1 -> 2 -> 3 -> 4 -> 5
        ListNode head = new ListNode(1,
                            new ListNode(2,
                                new ListNode(3,
                                    new ListNode(4,
                                        new ListNode(5)))));

        Solution sol = new Solution();
        ListNode middle = sol.MiddleNode(head);

        Console.WriteLine("Middle node value: " + middle.val);
    }
}


        // Middle of the Linked List(problem 876 of leetcode) 
        // full list from the middle


#nullable enable
using System;

public class ListNode
{
    public int val;
    public ListNode? next;
    public ListNode(int val = 0, ListNode? next = null)
    {
        this.val = val;
        this.next = next;
    }
}

public class Solution
{
    public ListNode MiddleNode(ListNode head)
    {
        ListNode slow = head;
        ListNode fast = head;

        while (fast != null && fast.next != null)
        {
            slow = slow.next!;
            fast = fast.next.next!;
        }

        return slow;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        ListNode head = new ListNode(1,
                            new ListNode(2,
                                new ListNode(3,
                                    new ListNode(4,
                                        new ListNode(5)))));

        Solution sol = new Solution();
        ListNode middle = sol.MiddleNode(head);

        Console.WriteLine("Output from the middle node:");
        while (middle != null)
        {
            Console.Write(middle.val + " ");
            middle = middle.next;
        }
    }
}