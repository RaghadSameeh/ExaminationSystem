using ExaminationSystem.DTO.Exam;
using ExaminationSystem.DTO.Student;

namespace ExaminationSystem.DTO.Result
{
    public class ResultCreateDTO
    {
        public int StudentID { get; set; }
        public int ExamID { get; set; }
        public double Score { get; set; }
    }
}
