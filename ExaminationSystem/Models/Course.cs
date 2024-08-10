namespace ExaminationSystem.Models
{
    public class Course : BaseModel
    {
        public string Name { get; set; }
        public int CreditHours { get; set; }
        public Instructor? Instructor { get; set; }
        public int? InstructorID { get; set; }

        public HashSet<Exam>? Exams { get; set; } = new HashSet<Exam>();

        public HashSet<StudentCourse>? courseStudents { get; set; } = new HashSet<StudentCourse>();

    }
}
