using System.Collections.Generic;
using System.Linq;
using Domain.Entities.Classes;
using Domain.Entities.Classes.Interfaces;
using Infra.Data;
using Microsoft.EntityFrameworkCore;

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
            return _context.Class.Include(x => x.Students).ToList();
        }

        public Class Get(string id)
        {   
            return _context.Class.Include(x => x.Students).FirstOrDefault(x => x.Id == id);
        }

        public bool Create(Class classe)
        {
            _context.Class.Add(classe);
            return _context.SaveChanges() == 1;
        }

        public void Update(Class classe)
        {
            _context.Class.Update(classe);
            _context.SaveChanges();
        }

        public bool Delete(string id)
        {
            var classe = _context.Class.Find(id);

            if (classe == null)
            {
                return false;
            }

            _context.Class.Remove(classe);

            return _context.SaveChanges() == 1;
        }
    }
}
