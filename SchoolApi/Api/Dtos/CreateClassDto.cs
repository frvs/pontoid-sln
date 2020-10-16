using Domain.Entities.Classes;

namespace Api.Dtos
{
    public class CreateClassDto
    {
        public Class Class { get; set; }

        public string SchoolId { get; set; }
    }
}
