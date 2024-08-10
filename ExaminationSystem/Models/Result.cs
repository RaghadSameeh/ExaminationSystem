namespace ExaminationSystem.Models
{
    public class Result : BaseModel
    {
        public Student Student { get; set; }
        public int StudentID { get; set; }
        public Exam Exam { get; set; }
        public int ExamID { get; set; }
        public double Score { get; set; }
        public int MaxScore { get; set; }
    }
}
