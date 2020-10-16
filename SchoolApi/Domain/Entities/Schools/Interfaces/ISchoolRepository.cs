using System.Collections.Generic;

namespace Domain.Entities.Schools.Interfaces
{
    public interface ISchoolRepository
    {
        List<School> GetAll();

        School Get(string id);

        bool Create(School classe);

        void Update(School classe);

        bool Delete(string id);
    }
}
