using System;
using System.Collections.Generic;
using System.Text;
using Domain.Entities.Classes;
using Domain.Entities.Classes.Interfaces;
using Domain.Entities.Students;

namespace Application.Services
{
    public class ClassService : IClassService
    {
        private readonly IClassRepository _classRepository;

        public ClassService(IClassRepository classRepository)
        {
            _classRepository = classRepository;
        }

        public List<Class> GetAll()
        {
            return _classRepository.GetAll();
        }

        public Class GetById(string id)
        {
            return _classRepository.Get(id) ?? new Class();
        }

        public bool Create(Class classe)
        {
            var sucessful = _classRepository.Create(classe);

            return sucessful;
        }

        public void Update(Class classe)
        {
            _classRepository.Update(classe);
        }

        public bool Delete(string id)
        {
            return _classRepository.Delete(id);
        }
    }
}
