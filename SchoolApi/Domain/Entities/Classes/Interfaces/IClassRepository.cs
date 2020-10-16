using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities.Classes.Interfaces
{
    public interface IClassRepository
    {
        List<Class> GetAll();

        Class Get(string id);

        bool Create(Class classe);

        void Update(Class classe);
        
        bool Delete(string id);
    }
}
