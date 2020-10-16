using Domain.Entities.Students;

namespace Api.Dtos
{
    public class CreateStudentDto
    {
        public Student Student { get; set; }

        public string ClassId { get; set; }
    }
}
