using System;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities.Students
{
    public class Student
    {
        public Student()
        {
            Id = Guid.NewGuid().ToString();
        }

        [Key]
        public string Id { get; set; }
        public string ClassId { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public string Cpf { get; set; }
    }
}
