using System;
using System.Collections.Generic;
using Domain.Entities.Classes;
using Domain.Entities.Classes.Interfaces;
using Infra.Data;

namespace Infra.Repositories
{
    public class ClassRepository : IClassRepository
    {
        private readonly DataContext _context;

        public ClassRepository(DataContext context)
        {
            _context = context;
        }

        public List<Class> GetAll()
        {
            throw new NotImplementedException();
        }

        public Class Get(string id)
        {
            throw new NotImplementedException();
        }

        public bool Create(Class classe)
        {
            throw new NotImplementedException();
        }

        public void Update(Class classe)
        {
            throw new NotImplementedException();
        }

        public bool Delete(string id)
        {
            throw new NotImplementedException();
        }
    }
}
