using System;
using System.Collections.Generic;

namespace Week5Day2
{
    public record Student(int RollNo, string Name, string Course, byte Marks);

    internal class Student_Record_Management_System
    {
        static List<Student> data = new();

        static void AddStudents()
        {
            Console.Write("Enter number of students: ");
            if (!int.TryParse(Console.ReadLine(), out int n) || n <= 0) return;

            for (int i = 0; i < n; i++)
            {
                Console.Write("RollNo: ");
                int roll = int.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Course: ");
                string course = Console.ReadLine();

                Console.Write("Marks: ");
                byte marks = byte.Parse(Console.ReadLine());

                if (roll > 0 && marks <= 100)
                    data.Add(new Student(roll, name, course, marks));
                else
                    Console.WriteLine("Invalid data, skipped.");
            }
        }

        static void Display()
        {
            if (data.Count == 0) Console.WriteLine("No records.");
            else
                data.ForEach(s =>
                    Console.WriteLine($"Roll No: {s.RollNo} | Name: {s.Name} | Course: {s.Course} | Marks: {s.Marks}"));
        }

        static void Search()
        {
            Console.Write("Enter RollNo: ");
            if (!int.TryParse(Console.ReadLine(), out int id)) return;

            var s = data.Find(x => x.RollNo == id);

            if (s == null) Console.WriteLine("Record not found.");
            else Console.WriteLine($"Roll No: {s.RollNo} | Name: {s.Name} | Course: {s.Course} | Marks: {s.Marks}");
        }

        static void Main()
        {
            while (true)
            {
                Console.WriteLine("\n1.Add  2.Display  3.Search  4.Exit");
                int ch = int.Parse(Console.ReadLine());

                if (ch == 1) AddStudents();
                else if (ch == 2) Display();
                else if (ch == 3) Search();
                else break;
            }
        }
    }
}