using System;
using System.Collections.Generic;
using System.Text;
using Domain.Entities.Students;

namespace Domain.Entities.Classes.Interfaces
{
    public interface IClassService
    {
        List<Class> GetAll();
        Class GetById(string id);
        bool Create(Class classe);
        void Update(Class classe);
        bool Delete(string id);
    }
}
