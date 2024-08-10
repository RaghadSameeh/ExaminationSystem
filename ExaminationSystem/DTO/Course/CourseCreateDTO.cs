using ExaminationSystem.DTO.Exam;
using ExaminationSystem.DTO.Instructor;
using ExaminationSystem.DTO.StudentCourse;

namespace ExaminationSystem.DTO.Course
{
    public class CourseCreateDTO
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int CreditHours { get; set; }
        public int? InstructorID { get; set; }

        public HashSet<ExamCreateDTO>? Exams { get; set; } = new HashSet<ExamCreateDTO>();

        public HashSet<StudentCourseDTO>? courseStudents { get; set; } = new HashSet<StudentCourseDTO>();
    }
}
