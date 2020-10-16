using Domain.Entities.Classes;
using Domain.Entities.Schools;
using Domain.Entities.Students;
using Microsoft.EntityFrameworkCore;

namespace Infra.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Student> Student { get; set; }
        public DbSet<School> School { get; set; }
        public DbSet<Class> Class { get; set; }

    }
}
