        // Circular LinkedList

using System;

public class Node
{
    public int Data;
    public Node? Next;

    public Node(int data)
    {
        Data = data;
        Next = null;
    }

    // Print circular list
    public void print(Node head)
    {
        Node temp = this;
        do
        {
            Console.Write("|" + temp.Data + "|->");
            temp = temp.Next;
        } while (temp != head);
        Console.WriteLine("(head)");
    }

    // Reverse print (recursive)
    public void reverse(Node head, Node current)
    {
        if (current.Next != head)
        {
            reverse(head, current.Next);
        }
        Console.Write("|" + current.Data + "|<-");
    }

    // Add node at end (recursive style, adapted for circular)
    public void add(int data, Node head)
    {
        if (Next == head)
        {
            Node newNode = new Node(data);
            newNode.Next = head;
            Next = newNode;
        }
        else
        {
            Next.add(data, head);
        }
    }
}

public class Mylist                                          
{
    public Node? HeadNode;

    public Mylist()
    {
        HeadNode = null;
    }

    // Add at end
    public void add(int data)
    {
        if (HeadNode == null)
        {
            HeadNode = new Node(data);
            HeadNode.Next = HeadNode; // circular link
        }
        else
        {
            HeadNode.add(data, HeadNode);
        }
    }

    // Print all
    public void print()
    {
        if (HeadNode != null)
        {
            HeadNode.print(HeadNode);
            Console.WriteLine();
        }
    }

    // Reverse print
    public void reverse()
    {
        if (HeadNode != null)
        {
            HeadNode.reverse(HeadNode, HeadNode);
            Console.WriteLine("(head)");
            Console.WriteLine();
        }
    }

    // Add at beginning
    public void addBiginning(int data)
    {
        Node newNode = new Node(data);
        if (HeadNode == null)
        {
            HeadNode = newNode;
            HeadNode.Next = HeadNode;
            return;
        }

        Node temp = HeadNode;
        while (temp.Next != HeadNode)
        {
            temp = temp.Next;
        }
        newNode.Next = HeadNode;
        temp.Next = newNode;
        HeadNode = newNode;
    }

    // Remove duplicates (adjacent)
    public void duplicate()
    {
        if (HeadNode == null) return;

        Node current = HeadNode;
        do
        {
            if (current.Data == current.Next.Data && current.Next != HeadNode)
            {
                current.Next = current.Next.Next;
            }
            else
            {
                current = current.Next;
            }
        } while (current.Next != HeadNode);
    }

    // Delete first node
    public void deleteFirst()
    {
        if (HeadNode == null) return;

        if (HeadNode.Next == HeadNode)
        {
            HeadNode = null;
            return;
        }

        Node temp = HeadNode;
        while (temp.Next != HeadNode)
        {
            temp = temp.Next;
        }
        temp.Next = HeadNode.Next;
        HeadNode = HeadNode.Next;
    }

    // Delete last node
    public void deleteLast()
    {
        if (HeadNode == null) return;

        if (HeadNode.Next == HeadNode)
        {
            HeadNode = null;
            return;
        }

        Node temp = HeadNode;
        while (temp.Next.Next != HeadNode)
        {
            temp = temp.Next;
        }
        temp.Next = HeadNode;
    }

    // Search element
    public bool search(int value)
    {
        if (HeadNode == null) return false;

        Node temp = HeadNode;
        do
        {
            if (temp.Data == value)
                return true;
            temp = temp.Next;
        } while (temp != HeadNode);

        return false;
    }

    // Insert after a given value
    public void insertAfter(int target, int data)
    {
        if (HeadNode == null) return;

        Node temp = HeadNode;
        do
        {
            if (temp.Data == target)
            {
                Node newNode = new Node(data);
                newNode.Next = temp.Next;
                temp.Next = newNode;
                return;
            }
            temp = temp.Next;
        } while (temp != HeadNode);
    }

    // Insert before a given value
    public void insertBefore(int target, int data)
    {
        if (HeadNode == null) return;

        if (HeadNode.Data == target)
        {
            addBiginning(data);
            return;
        }

        Node prev = HeadNode;
        Node current = HeadNode.Next;

        do
        {
            if (current.Data == target)
            {
                Node newNode = new Node(data);
                newNode.Next = current;
                prev.Next = newNode;
                return;
            }
            prev = current;
            current = current.Next;
        } while (current != HeadNode);
    }

    // Delete by value
    public void delete(int value)
    {
        if (HeadNode == null) return;

        if (HeadNode.Data == value && HeadNode.Next == HeadNode)
        {
            HeadNode = null;
            return;
        }

        Node prev = HeadNode;
        Node current = HeadNode.Next;

        do
        {
            if (current.Data == value)
            {
                prev.Next = current.Next;
                if (current == HeadNode)
                    HeadNode = current.Next;
                return;
            }
            prev = current;
            current = current.Next;
        } while (current != HeadNode);
    }

    // Delete middle node
    public void deleteMiddle()
    {
        if (HeadNode == null || HeadNode.Next == HeadNode)
        {
            HeadNode = null;
            return;
        }

        Node slow = HeadNode;
        Node fast = HeadNode;
        Node prev = null;

        while (fast.Next != HeadNode && fast.Next.Next != HeadNode)
        {
            fast = fast.Next.Next;
            prev = slow;
            slow = slow.Next;
        }

        if (prev != null)
        {
            prev.Next = slow.Next;
            if (slow == HeadNode)
                HeadNode = slow.Next;
        }
    }
}

public class Solution
{
    static void Main(string[] args)
    {
        Mylist list = new Mylist();

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
