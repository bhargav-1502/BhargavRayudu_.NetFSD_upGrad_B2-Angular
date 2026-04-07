using System;
using System.Collections.Generic;


namespace SRP
{
    internal class ReportGenerator
    {
        public void GenerateReport(List<Student> students)
        {
            Console.WriteLine("----- STUDENT REPORT -----");

            foreach (var student in students)
            {
                string result = student.Marks >= 40 ? "Pass" : "Fail";

                Console.WriteLine($"ID: {student.StudentId}");
                Console.WriteLine($"Name: {student.StudentName}");
                Console.WriteLine($"Marks: {student.Marks}");
                Console.WriteLine($"Result: {result}");
                Console.WriteLine("---------------");
            }
        }
    }
}