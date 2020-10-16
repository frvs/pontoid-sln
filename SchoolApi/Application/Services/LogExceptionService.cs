using System;
using Domain.Entities.LogExceptions;
using Domain.Entities.LogExceptions.Interfaces;

namespace Application.Services
{
    public class LogExceptionService : ILogExceptionService
    {
        private readonly ILogExceptionRepository _logExceptionRepository;

        public LogExceptionService(ILogExceptionRepository logExceptionRepository)
        {
            _logExceptionRepository = logExceptionRepository;
        }

        public void LogException(Exception exception)
        {
            var logException = new LogException
            {
                Message = exception.Message,
                Stack = exception.StackTrace
            };

            _logExceptionRepository.LogException(logException);
        }
    }
}
