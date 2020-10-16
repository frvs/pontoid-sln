using System;
using System.Collections.Generic;
using Domain.Entities.Students;
using Domain.Entities.Students.Interfaces;

namespace Application.Services
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _studentRepository;

        public StudentService(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public List<Student> GetAll()
        {
            return _studentRepository.GetAll();
        }

        public Student GetById(string id)
        {
            var student = _studentRepository.Get(id);

            return student ?? new Student();
        }

        public bool Create(Student student, string classId)
        {
            throw new NotImplementedException();
        }

        public void Update(Student student)
        {
            _studentRepository.Update(student);
        }

        public bool Delete(string id)
        {
            return _studentRepository.Delete(id);
        }
    }
}
