﻿namespace ExaminationSystem.Models
{
    public class StudentCourse :BaseModel
    {
        public Course Course { get; set; }
        public int CourseID { get; set; }
        public Student Student { get; set; }
        public int StudentID { get; set; }


    }
}
