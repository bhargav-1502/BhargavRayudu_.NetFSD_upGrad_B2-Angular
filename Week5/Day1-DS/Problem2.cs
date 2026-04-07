using System;

class Problem2
{
    static string[] actionStack = new string[10]; 
    static int top = -1;

    static void Main()
    {
        string[] actions = { "Type A", "Type B", "Type C", "Undo", "Undo" };

        foreach (string action in actions)
        {
            if (action.StartsWith("Type"))
            {
                Push(action);
            }
            else if (action == "Undo")
            {
                Pop();
            }

            Display();
        }
    }

    static void Push(string action)
    {
        if (top < actionStack.Length - 1)
        {
            top++;
            actionStack[top] = action;
            Console.WriteLine("Pushed: " + action);
        }
        else
        {
            Console.WriteLine("Stack Overflow! Cannot add more actions.");
        }
    }

    static void Pop()
    {
        if (top >= 0)
        {
            Console.WriteLine("Undone: " + actionStack[top]);
            top--;
        }
        else
        {
            Console.WriteLine("Stack Underflow! Nothing to undo.");
        }
    }

    static void Display()
    {
        Console.Write("Current State After Operations: ");

        if (top == -1)
        {
            Console.WriteLine("(empty)");
        }
        else
        {
            for (int i = 0; i <= top; i++)
            {
                Console.Write(actionStack[i]);
                if (i < top)
                    Console.Write(" -> "); 
            }
            Console.WriteLine();
        }

        Console.WriteLine();
    }
}