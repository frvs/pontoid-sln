using System.Collections.Generic;

namespace Domain.Entities.Students.Interfaces
{
    public interface IStudentService
    {
        List<Student> GetAll();
        Student GetById(string id);
        bool Create(Student student);
        void Update(Student student);
        bool Delete(string id);
    }
}
