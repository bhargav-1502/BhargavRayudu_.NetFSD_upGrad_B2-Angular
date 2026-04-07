using System;
using System.Collections.Generic;
using System.Linq;

class Problem1
{
    static void Main()
    {
        int[] marks = { 78, 85, 90, 67, 88 };

        Console.Write("Enter threshold: ");
        int threshold = int.Parse(Console.ReadLine());

        for (int i = 0; i < marks.Length; i++)
        {
            Console.WriteLine("Student " + (i + 1) + ": " + marks[i]);
        }

        int total = marks.Aggregate(0, (sum, m) => sum + m);
        double average = marks.Average();
        int countAbove = marks.Where(m => m > threshold).Count();
        int highest = marks.Max();

        Dictionary<string, int[]> subjectMarks = new Dictionary<string, int[]>()
        {
            { "Math", marks },
            { "Science", new int[] { 82, 79, 95, 70, 84 } },
            { "English", new int[] { 74, 88, 76, 91, 83 } }
        };

        Dictionary<string, int> subjectHighest = new Dictionary<string, int>();

        foreach (var item in subjectMarks)
        {
            subjectHighest[item.Key] = item.Value.Max();
        }

        Console.WriteLine("\nTotal Marks: " + total);
        Console.WriteLine("Average Marks: " + average);
        Console.WriteLine("Students above " + threshold + ": " + countAbove);
        Console.WriteLine("Highest Score: " + highest);

        Console.WriteLine("\nSubject-wise Highest:");
        foreach (var item in subjectHighest)
        {
            Console.WriteLine(item.Key + " : " + item.Value);
        }
    }
}