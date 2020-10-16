using System.Collections.Generic;
using Domain.Entities.Enums;
using Domain.Entities.Students;

namespace Domain.Entities.Classes
{
    public class Class
    {
        public string Description { get; set; }
        
        public int Grade { get; set; }
        
        public TurnEnum Turn { get; set; }

        public List<Student> Students { get; set; }
    }
}
