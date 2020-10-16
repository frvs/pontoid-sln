using System;
using Domain.Entities.ValueObjects;

namespace Domain.Entities.Students
{
    public class Student : Entity
    {
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public string Cpf { get; set; }
    }
}
