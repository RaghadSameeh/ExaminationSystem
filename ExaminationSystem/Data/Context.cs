using ExaminationSystem.Models;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;


namespace ExaminationSystem.Data
{
    public class Context : DbContext
    {
        public Context()
        {
            ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }

        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Choice> Choices { get; set; }
        public DbSet <Exam> Exams { get; set; }
        public DbSet <ExamQuestion> ExamQuestions { get; set; }
        public DbSet <Result> Results { get; set; }
        public DbSet<StudentCourse> StudentsCourse { get; set; }
        public DbSet<StudentExam> StudentsExams { get; set; }
        public DbSet<StudentAnswers> StudentAnswers { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Database=ExaminationSystemDB;Integrated Security=True;TrustServerCertificate=true")
                            .LogTo(log => Debug.WriteLine(log), LogLevel.Information)
                            .EnableSensitiveDataLogging();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            foreach(var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }
            base.OnModelCreating(modelBuilder);

        }
    }
}
