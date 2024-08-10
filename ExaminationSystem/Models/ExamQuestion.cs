namespace ExaminationSystem.Models
{
    public class ExamQuestion : BaseModel
    {
        public Exam Exam { get; set; }
        public int ExamID { get; set; }

        public Question Question { get; set; }
        public int QuestionID { get; set; }

    }
}
