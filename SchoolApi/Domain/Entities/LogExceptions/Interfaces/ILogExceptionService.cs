using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities.LogExceptions.Interfaces
{
    public interface ILogExceptionService
    {
        void LogException(Exception exception);
    }
}
