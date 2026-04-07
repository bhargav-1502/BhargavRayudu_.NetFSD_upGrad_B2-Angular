using System;
using System.Collections.Generic;

namespace RepositoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IStudentRepository repo = new StudentRepository();
            StudentService service = new StudentService(repo);

            // Add Students
            service.AddStudent(new Student { StudentId = 1, StudentName = "Bhargav", Course = "CSE" });
            service.AddStudent(new Student { StudentId = 2, StudentName = "Rahul", Course = "ECE" });

            Console.WriteLine("\n--- All Students ---");
            DisplayStudents(service.GetAllStudents());

            // Get by ID
            Console.WriteLine("\n--- Find Student (ID = 1) ---");
            var student = service.GetStudentById(1);

            if (student != null)
                Console.WriteLine($"{student.StudentId} - {student.StudentName} - {student.Course}");
            else
                Console.WriteLine("Student not found");

            // Delete
            Console.WriteLine("\n--- Delete Student (ID = 2) ---");
            service.DeleteStudent(2);

            Console.WriteLine("\n--- Updated List ---");
            DisplayStudents(service.GetAllStudents());
        }

        static void DisplayStudents(List<Student> students)
        {
            foreach (var s in students)
            {
                Console.WriteLine($"{s.StudentId} - {s.StudentName} - {s.Course}");
            }
        }
    }
}