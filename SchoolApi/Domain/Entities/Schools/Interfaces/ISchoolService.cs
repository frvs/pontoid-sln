using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities.Schools.Interfaces
{
    public interface ISchoolService
    {
        object GetAll();
        object GetById(string id);
        bool Create(School school);
        void Update(School school);
        bool Delete(string id);
    }
}
