using System.Collections.Generic;
using Domain.Entities.Enums;
using Domain.Entities.Students;
using Domain.Entities.ValueObjects;

namespace Domain.Entities.Classes
{
    public class Class : Entity
    {
        public string SchoolId { get; set; }
        public string Description { get; set; }
        
        public int Grade { get; set; }
        
        public TurnEnum Turn { get; set; }

        public List<Student> Students { get; set; }
    }
}
