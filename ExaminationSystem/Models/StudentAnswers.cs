namespace ExaminationSystem.Models
{
    public class StudentAnswers : BaseModel
    {
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public int ExamId { get; set; }
        public Exam Exam { get; set; }
        public int QuestionId { get; set; }
        public Question Question { get; set; }
        public int? ChoiceId { get; set; }
        public Choice? Choice { get; set; }
    }
}
