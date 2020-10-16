using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Domain.Entities.Enums;
using Domain.Entities.Students;

namespace Domain.Entities.Classes
{
    [Table("dbo.Class")]
    public class Class
    {
        public Class()
        {
            Id = Guid.NewGuid().ToString();
        }

        [Key]
        public string Id { get; set; }
        public string SchoolId { get; set; }
        public string Description { get; set; }
        
        public int Grade { get; set; }
        
        public TurnEnum Turn { get; set; }

        public List<Student> Students { get; set; }
    }
}
