using AutoMapper;
using ExaminationSystem.DTO.Instructor;
using ExaminationSystem.DTO.Question;
using ExaminationSystem.Helpers;
using ExaminationSystem.Models;
using ExaminationSystem.Repositories;

namespace ExaminationSystem.Services.Questions
{
    public class QuestionService : IQuestionService
    {
        IRepository<Question> _repository;
        IMapper _mapper; 
        public QuestionService(IRepository<Question> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
           
        }
        public int AddQuestion(QuestionCreateDTO questionCreateDTO)
        {

            Question question = _mapper.Map<Question>(questionCreateDTO);
            Question questionCreate = _repository.Add(question);
            _repository.SaveChanges();
            return question.ID;
        }

        public void Delete(int id)
        {
            Question question = _repository.GetWithTrackinByID(id);
            _repository.Delete(question);
            _repository.SaveChanges();
        }

        public IEnumerable<QuestionCreateDTO> GetAll()
        {
            IQueryable<Question> questions = _repository.GetAll();
            return questions.Map<QuestionCreateDTO>();
        }

        public QuestionCreateDTO GetById(int id)
        {
            Question question = _repository.GetByID(id);
            return _mapper.Map<QuestionCreateDTO>(question);
        }

        public int update(QuestionCreateDTO questionCreateDTO)
        {
            Question question = _mapper.Map<Question>(questionCreateDTO);
            _repository.Update(question);
            _repository.SaveChanges();
            return question.ID;
        }
    }
}
