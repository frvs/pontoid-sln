using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Domain.Entities.Classes;

namespace Domain.Entities.Schools
{
    [Table("dbo.School")]
    public class School
    {
        public School()
        {
            Id = Guid.NewGuid().ToString();
        }

        [Key]
        public string Id { get; set; }
        public string Name { get; set; }

        public int InepCode { get; set; }

        public List<Class> Classes { get; set; }
    }
}
