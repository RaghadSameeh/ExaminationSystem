using System.ComponentModel.DataAnnotations.Schema;

namespace ExaminationSystem.Models
{
    public class Choice : BaseModel
    {
        public string Text { get; set; }
        public bool IsCorrect { get; set; } = false;
        public Question Question { get; set; }
        public int QuestionID { get; set; }
        public HashSet<StudentAnswers>? StudentAnswers { get; set; } = new HashSet<StudentAnswers>();


    }
}
