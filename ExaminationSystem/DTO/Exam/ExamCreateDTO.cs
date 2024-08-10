using ExaminationSystem.DTO.Course;
using ExaminationSystem.DTO.ExamQuestion;
using ExaminationSystem.DTO.Result;
using ExaminationSystem.Models;

namespace ExaminationSystem.DTO.Exam
{
    public class ExamCreateDTO
    {
        public string Title { get; set; }

        public DateTime StartDate { get; set; }

        public ExamType ExamType { get; set; }
        public int CourseID { get; set; }

        public HashSet<ExamQuestionDTO>? ExamQuestions { get; set; } = new HashSet<ExamQuestionDTO>();

        public HashSet<ResultCreateDTO>? Results { get; set; } = new HashSet<ResultCreateDTO>();
    }
}
