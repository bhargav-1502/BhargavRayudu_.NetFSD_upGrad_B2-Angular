using System;

class Node
{
    public int Id;
    public string Name;
    public Node Next;

    public Node(int id, string name)
    {
        Id = id;
        Name = name;
        Next = null;
    }
}

class LinkedList
{
    Node head = null;

    // Insert at End
    public void InsertEnd(int id, string name)
    {
        Node newNode = new Node(id, name);
        if (head == null)
        {
            head = newNode;
            return;
        }
        Node temp = head;
        while (temp.Next != null)
            temp = temp.Next;
        temp.Next = newNode;
    }

    // Insert at Beginning
    public void InsertBeginning(int id, string name)
    {
        Node newNode = new Node(id, name);
        newNode.Next = head;
        head = newNode;
    }

    // Delete by Employee ID
    public void Delete(int id)
    {
        if (head == null)
        {
            Console.WriteLine("List is empty!");
            return;
        }
        if (head.Id == id)
        {
            head = head.Next;
            return;
        }
        Node temp = head;
        while (temp.Next != null && temp.Next.Id != id)
            temp = temp.Next;

        if (temp.Next == null)
            Console.WriteLine("Employee " + id + " not found!");
        else
            temp.Next = temp.Next.Next;
    }

    // Display Employee List
    public void Display()
    {
        if (head == null)
        {
            Console.WriteLine("No employees found.");
            return;
        }
        Node temp = head;
        while (temp != null)
        {
            Console.WriteLine(temp.Id + " - " + temp.Name);
            temp = temp.Next;
        }
    }
}

class Problem3
{
    static void Main()
    {
        LinkedList list = new LinkedList();

        // Insert employees
        list.InsertEnd(101, "John");
        list.InsertEnd(102, "Sara");
        list.InsertEnd(103, "Mike");

        // Delete employee 102
        list.Delete(102);

        // Display result
        Console.WriteLine("Employee List After Deletion:");
        list.Display();
    }
}