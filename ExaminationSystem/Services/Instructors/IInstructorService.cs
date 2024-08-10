using ExaminationSystem.DTO.Course;
using ExaminationSystem.DTO.Instructor;

namespace ExaminationSystem.Services.Instructors
{
    public interface IInstructorService
    {
        public int AddInstructor(InstructorCreateDTO instructorCreateDTO);
        public IEnumerable<InstructorCreateDTO> GetAll();
        public InstructorCreateDTO GetById(int id);
        public void Delete(int id);
        public int update(InstructorCreateDTO instructorCreateDTO);
    }
}
