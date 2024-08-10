using AutoMapper;
using ExaminationSystem.DTO.Choice;
using ExaminationSystem.DTO.Course;
using ExaminationSystem.Helpers;
using ExaminationSystem.Models;
using ExaminationSystem.Repositories;

namespace ExaminationSystem.Services.Choices
{
    public class ChoiceService : IChoiceService
    {
        IRepository<Choice> _repository;
        IMapper _mapper;

        public ChoiceService(IRepository<Choice> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;

        }
        public int AddChoice(ChoiceCreateDTO choiceDTO)
        {
            Choice choice = _mapper.Map<Choice>(choiceDTO);
            Choice choiceCreate = _repository.Add(choice);
            _repository.SaveChanges();
            return choiceCreate.ID;
        }

        public void Delete(int id)
        {
            Choice choice = _repository.GetWithTrackinByID(id);
            _repository.Delete(choice);
            _repository.SaveChanges();
        }

        public IEnumerable<ChoiceCreateDTO> GetAll()
        {
            IQueryable<Choice> choices = _repository.GetAll();
            return choices.Map<ChoiceCreateDTO>();
        }

        public ChoiceCreateDTO GetById(int id)
        {

            Choice choice = _repository.GetByID(id);
            return _mapper.Map<ChoiceCreateDTO>(choice);
        }

        public int update(ChoiceCreateDTO choiceCreateDTO)
        {
            Choice choice = _mapper.Map<Choice>(choiceCreateDTO);
            _repository.Update(choice);
            _repository.SaveChanges();
            return choice.ID;
        }
    }
}
