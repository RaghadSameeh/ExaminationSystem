using ExaminationSystem.DTO.Course;

namespace ExaminationSystem.Services.Courses
{
    public interface ICourseService
    {
       public int AddCourse (CourseCreateDTO course);
       public IEnumerable<CourseCreateDTO> GetAll();
        public CourseCreateDTO GetById (int id);
        public void Delete(int id);
        public int update(CourseCreateDTO courseCreateDTO);

    }
}
