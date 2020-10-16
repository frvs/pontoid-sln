using System;
using System.Collections.Generic;
using Domain.Entities.Schools;
using Domain.Entities.Schools.Interfaces;

namespace Application.Services
{
    public class SchoolService : ISchoolService
    {
        private readonly ISchoolRepository _schoolRepository;

        public SchoolService(ISchoolRepository schoolRepository)
        {
            _schoolRepository = schoolRepository;
        }

        public List<School> GetAll()
        {
            return _schoolRepository.GetAll();
        }

        public School GetById(string id)
        {
            var school = _schoolRepository.Get(id);

            return school ?? new School();
        }

        public bool Create(School school)
        {
            return _schoolRepository.Create(school);
        }

        public void Update(School school)
        {
            _schoolRepository.Update(school);
        }

        public bool Delete(string id)
        {
            return  _schoolRepository.Delete(id);
        }
    }
}
