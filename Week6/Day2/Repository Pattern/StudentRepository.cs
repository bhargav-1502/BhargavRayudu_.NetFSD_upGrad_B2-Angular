using System;
using System.Collections.Generic;
using System.Linq;

namespace RepositoryPattern
{
    internal class StudentRepository : IStudentRepository
    {
        private List<Student> students = new List<Student>();

        public void AddStudent(Student student)
        {
            students.Add(student);
            Console.WriteLine("Student added successfully.");
        }

        public List<Student> GetAllStudents()
        {
            return students;
        }

        public Student GetStudentById(int id)
        {
            return students.FirstOrDefault(s => s.StudentId == id);
        }

        public void DeleteStudent(int id)
        {
            var student = students.FirstOrDefault(s => s.StudentId == id);
            if (student != null)
            {
                students.Remove(student);
                Console.WriteLine("Student deleted successfully.");
            }
            else
            {
                Console.WriteLine("Student not found.");
            }
        }
    }
}