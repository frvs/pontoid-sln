using System.Collections.Generic;

namespace Domain.Entities.Students.Interfaces
{
    public interface IStudentRepository
    {
        List<Student> GetAll();

        Student Get(string id);

        bool Create(Student classe);

        void Update(Student classe);

        bool Delete(string id);
    }
}
