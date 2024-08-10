using ExaminationSystem.DTO.Course;
using ExaminationSystem.DTO.Exam;
using ExaminationSystem.DTO.Question;

namespace ExaminationSystem.DTO.Instructor
{
    public class InstructorCreateDTO
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthdate { get; set; }
        public HashSet<CourseCreateDTO>? Courses { get; set; } = new HashSet<CourseCreateDTO>();
        public HashSet<ExamCreateDTO>? Exams { get; set; } = new HashSet<ExamCreateDTO>();
        public HashSet<QuestionCreateDTO>? Questions { get; set; } = new HashSet<QuestionCreateDTO>();

    }
}
