using System;
using System.Collections.Generic;

namespace RepositoryPattern
{
    interface IStudentRepository
    {
        void AddStudent(Student student);
        List<Student> GetAllStudents();
        Student GetStudentById(int id);
        void DeleteStudent(int id);
    }
}
