using System;

class StringOps
{
    public void Print(char[] str, int length)
    {
        for (int i = 0; i < length; i++)
            Console.Write(str[i]);
        Console.WriteLine();
    }

    public int Length(char[] str)
    {
        int count = 0;
        foreach (char c in str)
        {
            if (c == '\0') break;
            count++;
        }
        return count;
    }

    public int Search(char[] str, int length, char target)
    {
        for (int i = 0; i < length; i++)
        {
            if (str[i] == target)
                return i;
        }
        return -1; 
    }

    
    public int Insert(char[] str, int length, char ch, int pos)
    {
        if (pos < 0 || pos > length)
            return length; 

        for (int i = length; i > pos; i--)
        {
            str[i] = str[i - 1]; 
        }
        str[pos] = ch;
        return length + 1;
    }
    public int Delete(char[] str, int length, int pos)
    {
        if (pos < 0 || pos >= length)
            return length; 

        for (int i = pos; i < length - 1; i++)
        {
            str[i] = str[i + 1]; 
        }
        str[length - 1] = '\0'; 
        return length - 1;
    }

    public void Replace(char[] str, int length, char oldChar, char newChar)
    {
        for (int i = 0; i < length; i++)
        {
            if (str[i] == oldChar)
                str[i] = newChar;
        }
    }
}

class Program
{
    static void Main()
    {
        char[] str = new char[100]; 
        string initial = "hello";
        for (int i = 0; i < initial.Length; i++)
            str[i] = initial[i];

        int length = initial.Length;

        StringOps ops = new StringOps();

        Console.Write("Initial String: ");
        ops.Print(str, length);

        // Insert
        length = ops.Insert(str, length, 'X', 2);
        Console.Write("After Insert: ");
        ops.Print(str, length);

        // Delete
        length = ops.Delete(str, length, 3);
        Console.Write("After Delete: ");
        ops.Print(str, length);

        // Replace
        ops.Replace(str, length, 'o', 'Z');
        Console.Write("After Replace: ");
        ops.Print(str, length);

        // Search
        int pos = ops.Search(str, length, 'l');
        Console.WriteLine("Position of 'l': " + pos);

        // Length
        Console.WriteLine("Length: " + ops.Length(str));
    }
}
