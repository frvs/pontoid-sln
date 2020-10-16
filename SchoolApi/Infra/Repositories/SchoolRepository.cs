using System;
using System.Collections.Generic;
using System.Linq;
using Domain.Entities.Schools;
using Domain.Entities.Schools.Interfaces;
using Infra.Data;
using Microsoft.EntityFrameworkCore;

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
            return _context.School.Include(x => x.Classes).ThenInclude(y => y.Students).ToList();
        }

        public School Get(string id)
        {
            return _context.School.Include(x => x.Classes).ThenInclude(y => y.Students).FirstOrDefault(z => z.Id == id);
        }

        public bool Create(School school)
        {
            _context.School.Add(school);

            return _context.SaveChanges() == 1;
        }

        public void Update(School school)
        {

            _context.School.Update(school);

            _context.SaveChanges();
        }

        public bool Delete(string id)
        {
            var school = _context.School.Find(id);
            
            if (school == null)
            {
                return false;
            }

            _context.School.Remove(school);

            return _context.SaveChanges() == 1;
        }
    }
}
