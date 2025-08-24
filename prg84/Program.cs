        //Doubly LinkedList

using System;

public class Node
{
    public int Data;
    public Node? Next;
    public Node? Prev;

    public Node(int data)
    {
        Data = data;
        Next = null;
        Prev = null;
    }

    public void print()
    {
        Console.Write("|" + Data + "|<->");
        if (Next != null)
        {
            Next.print();
        }
        else
        {
            Console.WriteLine("null");
        }
    }

    public void reverse()
    {
        if (Next != null)
        {
            Next.reverse();
        }
        Console.Write("|" + Data + "|<-");
    }

    public void add(int data)
    {
        if (Next == null)
        {
            Node newNode = new Node(data);
            newNode.Prev = this;
            Next = newNode;
        }
        else
        {
            Next.add(data);
        }
    }
}

public class MyDoublyList
{
    public Node? HeadNode;

    public MyDoublyList()
    {
        HeadNode = null;
    }

    // Add at end
    public void add(int data)
    {
        if (HeadNode == null)
        {
            HeadNode = new Node(data);
        }
        else
        {
            HeadNode.add(data);
        }
    }

    // Print all
    public void print()
    {
        if (HeadNode != null)
        {
            HeadNode.print();
            Console.WriteLine();
        }
    }

    // Reverse print
    public void reverse()
    {
        if (HeadNode != null)
        {
            HeadNode.reverse();
            Console.WriteLine();
        }
    }

    // Add at beginning
    public void addBiginning(int data)
    {
        Node temp = new Node(data);
        if (HeadNode != null)
        {
            temp.Next = HeadNode;
            HeadNode.Prev = temp;
        }
        HeadNode = temp;
    }

    // Remove duplicates (adjacent)
    public void duplicate()
    {
        if (HeadNode == null) return;

        Node? current = HeadNode;
        while (current != null && current.Next != null)
        {
            if (current.Data == current.Next.Data)
            {
                current.Next = current.Next.Next;
                if (current.Next != null)
                    current.Next.Prev = current;
            }
            else
            {
                current = current.Next;
            }
        }
    }

    // Delete first node
    public void deleteFirst()
    {
        if (HeadNode == null) return;
        HeadNode = HeadNode.Next;
        if (HeadNode != null)
            HeadNode.Prev = null;
    }

    // Delete last node
    public void deleteLast()
    {
        if (HeadNode == null) return;
        if (HeadNode.Next == null)
        {
            HeadNode = null;
            return;
        }

        Node? current = HeadNode;
        while (current.Next != null)
        {
            current = current.Next;
        }
        current.Prev!.Next = null;
    }

    // Search element
    public bool search(int value)
    {
        Node? current = HeadNode;
        while (current != null)
        {
            if (current.Data == value)
                return true;
            current = current.Next;
        }
        return false;
    }

    // Insert after
    public void insertAfter(int target, int data)
    {
        Node? current = HeadNode;
        while (current != null)
        {
            if (current.Data == target)
            {
                Node newNode = new Node(data);
                newNode.Next = current.Next;
                newNode.Prev = current;
                if (current.Next != null)
                    current.Next.Prev = newNode;
                current.Next = newNode;
                return;
            }
            current = current.Next;
        }
    }

    // Insert before
    public void insertBefore(int target, int data)
    {
        if (HeadNode == null) return;

        if (HeadNode.Data == target)
        {
            addBiginning(data);
            return;
        }

        Node? current = HeadNode;
        while (current != null && current.Data != target)
        {
            current = current.Next;
        }

        if (current != null)
        {
            Node newNode = new Node(data);
            newNode.Prev = current.Prev;
            newNode.Next = current;
            if (current.Prev != null)
                current.Prev.Next = newNode;
            current.Prev = newNode;
        }
    }

    // Delete by value
    public void delete(int value)
    {
        if (HeadNode == null) return;

        if (HeadNode.Data == value)
        {
            deleteFirst();
            return;
        }

        Node? current = HeadNode;
        while (current != null && current.Data != value)
        {
            current = current.Next;
        }

        if (current != null)
        {
            if (current.Next != null)
                current.Next.Prev = current.Prev;
            if (current.Prev != null)
                current.Prev.Next = current.Next;
        }
    }

    // Delete middle node
    public void deleteMiddle()
    {
        if (HeadNode == null || HeadNode.Next == null)
        {
            HeadNode = null;
            return;
        }

        Node? slow = HeadNode;
        Node? fast = HeadNode;
        Node? prev = null;

        while (fast != null && fast.Next != null)
        {
            fast = fast.Next.Next;
            prev = slow;
            slow = slow.Next;
        }

        if (prev != null && slow != null)
        {
            prev.Next = slow.Next;
            if (slow.Next != null)
                slow.Next.Prev = prev;
        }
    }
}

public class Solution
{
    static void Main(string[] args)
    {
        MyDoublyList list = new MyDoublyList();

        // Add nodes
        list.add(1);
        list.add(2);
        list.add(3);
        list.add(4);
        list.add(5);
        Console.WriteLine("Initial list:");
        list.print();

        // Add at beginning
        list.addBiginning(0);
        Console.WriteLine("After adding 0 at beginning:");
        list.print();

        // Insert After
        list.insertAfter(2, 99);
        Console.WriteLine("After inserting 99 after 2:");
        list.print();

        // Insert Before
        list.insertBefore(4, 88);
        Console.WriteLine("After inserting 88 before 4:");
        list.print();

        // Delete first
        list.deleteFirst();
        Console.WriteLine("After deleting first node:");
        list.print();

        // Delete last
        list.deleteLast();
        Console.WriteLine("After deleting last node:");
        list.print();

        // Delete specific value
        list.delete(99);
        Console.WriteLine("After deleting node with value 99:");
        list.print();

        // Duplicate removal
        list.add(5);
        list.add(5);
        Console.WriteLine("After adding duplicate 5s:");
        list.print();
        list.duplicate();
        Console.WriteLine("After removing duplicates:");
        list.print();

        // Search
        Console.WriteLine("Searching for 3: " + (list.search(3) ? "Found" : "Not Found"));
        Console.WriteLine("Searching for 99: " + (list.search(99) ? "Found" : "Not Found"));

        // Delete middle
        list.deleteMiddle();
        Console.WriteLine("After deleting middle node:");
        list.print();

        // Reverse print
        Console.WriteLine("Reverse print:");
        list.reverse();
    }
}