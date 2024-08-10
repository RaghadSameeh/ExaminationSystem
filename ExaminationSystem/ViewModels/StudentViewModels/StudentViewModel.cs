using ExaminationSystem.DTO.Result;
using ExaminationSystem.DTO.Student;
using ExaminationSystem.DTO.StudentAnswers;
using ExaminationSystem.DTO.StudentExam;

namespace ExaminationSystem.ViewModels.StudentViewModels
{
    public class StudentViewModel
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthdate { get; set; }
        public HashSet<StudentCreateDto>? StudentCourses { get; set; } = new HashSet<StudentCreateDto> ();
        public HashSet<ResultCreateDTO>? Results { get; set; } = new HashSet<ResultCreateDTO> ();
        public HashSet<StudentExamDTO>? StudentExams { get; set; } = new HashSet<StudentExamDTO>();
        public HashSet<StudentAnswersDTO>? StudentAnswers { get; set; } = new HashSet<StudentAnswersDTO>();
    }
}
