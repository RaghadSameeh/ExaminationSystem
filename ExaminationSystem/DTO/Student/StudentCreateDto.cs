using ExaminationSystem.DTO.Course;
using ExaminationSystem.DTO.Result;
using ExaminationSystem.DTO.StudentAnswers;
using ExaminationSystem.DTO.StudentCourse;
using ExaminationSystem.DTO.StudentExam;
using ExaminationSystem.Models;

namespace ExaminationSystem.DTO.Student
{
    public class StudentCreateDto
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthdate { get; set; }

        public HashSet<StudentCourseDTO>? StudentCourses { get; set; } = new HashSet<StudentCourseDTO> { };
        public HashSet<ResultCreateDTO>? Results { get; set; } = new HashSet<ResultCreateDTO> { };
        public HashSet<StudentExamDTO>? StudentExams { get; set; } = new HashSet<StudentExamDTO>();
        public HashSet<StudentAnswersDTO>? StudentAnswers { get; set; } = new HashSet<StudentAnswersDTO>();
    }
}
