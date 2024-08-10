using ExaminationSystem.DTO.Question;
using ExaminationSystem.Models;

namespace ExaminationSystem.DTO.Choice
{
    public class ChoiceCreateDTO
    {
        public string Text { get; set; }
        public bool IsCorrect { get; set; } = false;
        public int QuestionID { get; set; }

    }
}
