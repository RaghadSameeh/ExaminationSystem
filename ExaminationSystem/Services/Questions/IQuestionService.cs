using ExaminationSystem.DTO.Instructor;
using ExaminationSystem.DTO.Question;

namespace ExaminationSystem.Services.Questions
{
    public interface IQuestionService
    {
        public int AddQuestion(QuestionCreateDTO questionCreateDTO);
        public IEnumerable<QuestionCreateDTO> GetAll();
        public QuestionCreateDTO GetById(int id);
        public void Delete(int id);
        public int update(QuestionCreateDTO questionCreateDTO);
    }
}
