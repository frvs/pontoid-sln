using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities.Students.Interfaces
{
    public interface IStudentService
    {
        List<Student> GetAll();
        Student GetById(string id);
        bool Create(Student student, string classId);
        void Update(Student student);
        bool Delete(string id);
    }
}
