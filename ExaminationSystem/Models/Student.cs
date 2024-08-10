namespace ExaminationSystem.Models
{
    public class Student : BaseModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthdate { get; set; }

        public HashSet<StudentCourse>? StudentCourses { get; set; } = new HashSet<StudentCourse> ();
        public HashSet <Result>? Results { get; set; } = new HashSet<Result>();
        public HashSet<StudentExam>? StudentExams { get; set; } = new HashSet<StudentExam>();
        public HashSet<StudentAnswers>? StudentAnswers { get; set; } = new HashSet<StudentAnswers>();



    }
}
