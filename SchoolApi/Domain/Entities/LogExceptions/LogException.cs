using System;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities.LogExceptions
{
    public class LogException
    {
        [Key]
        public string Id { get; set; }

        public LogException()
        {
            Id = Guid.NewGuid().ToString();
            Hour = DateTime.Now;
        }

        public string Message { get; set; }
        public string Stack { get; set; }
        public DateTime Hour { get; set; }
    }
}
