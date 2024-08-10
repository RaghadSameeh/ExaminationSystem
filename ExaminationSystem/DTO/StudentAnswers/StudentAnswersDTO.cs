using ExaminationSystem.DTO.Choice;

namespace ExaminationSystem.DTO.StudentAnswers
{
    public class StudentAnswersDTO
    {
        public int StudentId { get; set; }
        public int ExamId { get; set; }
        public int QuestionId { get; set; }
        public int? ChoiceId { get; set; }
    }
}
