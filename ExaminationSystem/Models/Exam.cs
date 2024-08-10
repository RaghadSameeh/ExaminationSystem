namespace ExaminationSystem.Models
{
    public enum ExamType
    {
        Quiz,
        Final
    }
    public class Exam : BaseModel
    {
        public string Title { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public ExamType ExamType { get; set; }
        public Course Course { get; set; }
        public int CourseID { get; set; }
        public Instructor Instructor { get; set; }
        public int InstructorID { get; set; }

        public HashSet <ExamQuestion>? ExamQuestions { get; set; } = new HashSet<ExamQuestion>();

        public HashSet<Result >? Results { get; set; } = new HashSet<Result> ();

        public HashSet<StudentExam>? StudentExams { get; set; } = new HashSet<StudentExam> ();
        public HashSet<StudentAnswers>? StudentAnswers { get; set; } = new HashSet<StudentAnswers>();


    }
}
