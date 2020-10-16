using Domain.Entities.LogExceptions;
using Domain.Entities.LogExceptions.Interfaces;
using Infra.Data;

namespace Infra.Repositories
{
    public class LogExceptionRepository : ILogExceptionRepository
    {
        private readonly DataContext _context;

        public LogExceptionRepository(DataContext context)
        {
            _context = context;
        }

        public void LogException(LogException logException)
        {
            _context.LogException.Add(logException);
            _context.SaveChanges();
        }
    }
}
