using System;
using System.Collections.Generic;
using System.Text;
using Domain.Entities.Students;

namespace Domain.Entities.Classes.Interfaces
{
    public interface IClassService
    {
        List<Class> GetAll();
        Student GetById(string id);
        bool Create(Class classDtoClass, string classDtoSchoolId);
        void Update(Class classe);
        bool Delete(string id);
    }
}
