using ExaminationSystem.DTO.Choice;
using ExaminationSystem.DTO.Course;

namespace ExaminationSystem.Services.Choices
{
    public interface IChoiceService
    {
        public int AddChoice(ChoiceCreateDTO choice);
        public IEnumerable<ChoiceCreateDTO> GetAll();
        public ChoiceCreateDTO GetById(int id);
        public void Delete(int id);
        public int update(ChoiceCreateDTO choiceCreateDTO);
    }
}
