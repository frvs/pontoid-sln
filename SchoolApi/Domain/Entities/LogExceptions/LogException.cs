using System;

namespace Domain.Entities.LogExceptions
{
    public class LogException
    {
        public LogException()
        {
            Hour = DateTime.Now;
        }

        public string Message { get; set; }
        public string Stack { get; set; }
        public DateTime Hour { get; set; }
    }
}
