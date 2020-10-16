using System;

namespace Domain.Entities.LogExceptions.Interfaces
{
    public interface ILogExceptionService
    {
        void LogException(Exception exception);
    }
}
