        //Given LinkedList is circular or not?

using System;

class Node
{
    public int data;
    public Node next;

    public Node(int data)
    {
        this.data = data;
        this.next = null;
    }
}

class LinkedList
{
    private Node head;

    public void Add(int data)
    {
        Node newNode = new Node(data);

        if (head == null)
        {
            head = newNode;
            return;
        }

        Node temp = head;
        while (temp.next != null)
        {
            temp = temp.next;
        }
        temp.next = newNode;
    }

    // Make the list circular (for testing)
    public void MakeCircular()
    {
        if (head == null) return;

        Node temp = head;
        while (temp.next != null)
        {
            temp = temp.next;
        }
        temp.next = head;  // last node points to head
    }

    // Function to check if list is circular
    public bool IsCircular()
    {
        if (head == null)
            return false;

        Node slow = head, fast = head;

        while (fast != null && fast.next != null)
        {
            slow = slow.next;
            fast = fast.next.next;

            if (slow == fast)
                return true;
        }
        return false;
    }

    public void Print()
    {
        Node temp = head;
        int count = 0;  // to avoid infinite loop in circular case

        while (temp != null && count < 20)
        {
            Console.Write(temp.data + " -> ");
            temp = temp.next;
            count++;
        }
        Console.WriteLine("null");
    }
}

class Solution
{
    static void Main()
    {
        LinkedList list = new LinkedList();

        list.Add(10);
        list.Add(20);
        list.Add(30);
        list.Add(40);

        Console.WriteLine("Normal List:");
        list.Print();
        Console.WriteLine("Is Circular? " + list.IsCircular());

        // Now make it circular
        Console.Write("\nNow make it circular");
        list.MakeCircular();
        Console.WriteLine("\nAfter making circular:");
        Console.WriteLine("Is Circular? " + list.IsCircular());
    }
}