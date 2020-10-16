using System;
using System.Collections.Generic;
using Domain.Entities.Schools;
using Domain.Entities.Schools.Interfaces;
using Infra.Data;

namespace Infra.Repositories
{
    public class SchoolRepository : ISchoolRepository
    {
        private readonly DataContext _context;

        public SchoolRepository(DataContext context)
        {
            _context = context;
        }

        public List<School> GetAll()
        {
            throw new NotImplementedException();
        }

        public School Get(string id)
        {
            throw new NotImplementedException();
        }

        public bool Create(School classe)
        {
            throw new NotImplementedException();
        }

        public void Update(School classe)
        {
            throw new NotImplementedException();
        }

        public bool Delete(string id)
        {
            throw new NotImplementedException();
        }
    }
}
