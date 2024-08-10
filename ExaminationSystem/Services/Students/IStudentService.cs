using ExaminationSystem.DTO.Instructor;
using ExaminationSystem.DTO.Student;

namespace ExaminationSystem.Services.Students
{
    public interface IStudentService
    {
        public int AddStudent(StudentCreateDto studentCreateDto);
        public IEnumerable<StudentCreateDto> GetAll();
        public StudentCreateDto GetById(int id);
        public void Delete(int id);
        public int update(StudentCreateDto studentCreateDto);
    }
}
