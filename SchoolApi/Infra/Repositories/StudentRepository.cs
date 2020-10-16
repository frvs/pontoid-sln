using System.Collections.Generic;
using System.Linq;
using Domain.Entities.Students;
using Domain.Entities.Students.Interfaces;
using Infra.Data;

namespace Infra.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private readonly DataContext _context;

        public StudentRepository(DataContext context)
        {
            _context = context;
        }

        public List<Student> GetAll()
        {
            return _context.Student.ToList();
        }

        public Student Get(string id)
        {
            return _context.Student.FirstOrDefault(x => x.Id == id);
        }

        public bool Create(Student student)
        {
            _context.Student.Add(student);

            return _context.SaveChanges() == 1;
        }

        public void Update(Student student)
        {
            _context.Student.Update(student);

            _context.SaveChanges();
        }

        public bool Delete(string id)
        {
            var student = _context.Student.Find(id);

            if (student == null)
            {
                return false;
            }

            _context.Student.Remove(student);

            return _context.SaveChanges() == 1;
        }
    }
}
