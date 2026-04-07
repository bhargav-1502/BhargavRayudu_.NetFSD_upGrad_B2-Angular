using System;
using System.Collections.Generic;

namespace RepositoryPattern
{
    internal class StudentService
    {
        private readonly IStudentRepository repo;

        public StudentService(IStudentRepository repo)
        {
            this.repo = repo;
        }

        // Add Student
        public void AddStudent(Student student)
        {
            if (student.StudentId <= 0)
            {
                Console.WriteLine("Invalid Student ID");
                return;
            }

            repo.AddStudent(student);
        }

        // Get All Students
        public List<Student> GetAllStudents()
        {
            return repo.GetAllStudents();
        }

        // Get Student by ID
        public Student? GetStudentById(int id)
        {
            return repo.GetStudentById(id);
        }

        // Delete Student
        public void DeleteStudent(int id)
        {
            repo.DeleteStudent(id);
        }
    }
}