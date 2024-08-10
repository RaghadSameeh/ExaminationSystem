using ExaminationSystem.DTO.Choice;
using ExaminationSystem.DTO.ExamQuestion;
using ExaminationSystem.DTO.StudentAnswers;
using ExaminationSystem.Models;

namespace ExaminationSystem.DTO.Question
{
    public class QuestionCreateDTO
    {
        public int ID { get; set; }
        public string Text { get; set; }
        public int Grade { get; set; }
        public DifficultyLevel DifficultyLevel { get; set; }
        public HashSet<ChoiceCreateDTO>? Choices { get; set; } = new HashSet<ChoiceCreateDTO>();
        public HashSet<ExamQuestionDTO>? ExamQuestions { get; set; } = new HashSet<ExamQuestionDTO>();
        public HashSet<StudentAnswersDTO>? StudentAnswers { get; set; } = new HashSet<StudentAnswersDTO>();
        public int InstructorID { get; set; }
    }
}
