using System.Collections.Generic;
using Domain.Entities.Classes;
using Domain.Entities.ValueObjects;

namespace Domain.Entities.Schools
{
    public class School : Entity
    {
        public string Name { get; set; }

        public int InepCode { get; set; }

        public List<Class> Classes { get; set; }
    }
}
