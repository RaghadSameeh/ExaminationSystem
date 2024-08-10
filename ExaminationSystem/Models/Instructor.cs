namespace ExaminationSystem.Models
{
    public class Instructor : BaseModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthdate { get; set; }
        public HashSet<Course>? Courses { get; set; } = new HashSet<Course>();
        public HashSet<Exam>? Exams { get; set; } = new HashSet<Exam>();
        public HashSet<Question>? Questions { get; set; } = new HashSet<Question>();



    }
}
