using System;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities.ValueObjects
{
    public abstract class Entity
    {
        protected Entity()
        {
            Id = Guid.NewGuid().ToString();
        }

        [Key] 
        public string Id;
    }
}
