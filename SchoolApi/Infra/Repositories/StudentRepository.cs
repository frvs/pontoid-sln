using System;
using System.Collections.Generic;
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
            throw new NotImplementedException();
        }

        public Student Get(string id)
        {
            throw new NotImplementedException();
        }

        public bool Create(Student classe)
        {
            throw new NotImplementedException();
        }

        public void Update(Student classe)
        {
            throw new NotImplementedException();
        }

        public bool Delete(string id)
        {
            throw new NotImplementedException();
        }
    }
}
