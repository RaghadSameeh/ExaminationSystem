namespace ExaminationSystem.Models
{

    public enum DifficultyLevel
    {
        Simple,
        Medium,
        Hard
    }
    public class Question : BaseModel
    {
        public string Text { get; set; }
        public int Grade { get; set; }
        public DifficultyLevel DifficultyLevel { get; set; }
        public HashSet<Choice>? Choices { get; set; } = new HashSet<Choice>();
        public HashSet<ExamQuestion>? ExamQuestions { get; set; } = new HashSet<ExamQuestion>();
        public HashSet<StudentAnswers>? StudentAnswers { get; set; } = new HashSet<StudentAnswers>();
        public Instructor Instructor { get; set; }
        public int InstructorID { get; set; }



    }
}
