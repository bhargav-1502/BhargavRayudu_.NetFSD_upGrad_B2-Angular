using System;

namespace SRP
{
    class Program
    {
            static void Main(string[] args)
            {
            
                StudentRepository repository = new StudentRepository();

               
                repository.AddStudent(new Student { StudentId = 1, StudentName = "Bhargav", Marks = 85 });
                repository.AddStudent(new Student { StudentId = 2, StudentName = "Rahul", Marks = 35 });
                repository.AddStudent(new Student { StudentId = 3, StudentName = "Sneha", Marks = 60 });

                ReportGenerator reportGenerator = new ReportGenerator();
                reportGenerator.GenerateReport(repository.GetAllStudents());

                Console.ReadLine();
            }
        }
    }

