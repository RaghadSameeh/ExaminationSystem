namespace ExaminationSystem.ViewModels.ChoiceViewModels
{
    public class ChoiceViewModel
    {
        public string Text { get; set; }
        public bool IsCorrect { get; set; } = false;
        public int QuestionID { get; set; }
    }
}
