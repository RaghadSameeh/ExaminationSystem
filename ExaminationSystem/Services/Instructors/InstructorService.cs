using AutoMapper;
using ExaminationSystem.DTO.Course;
using ExaminationSystem.DTO.Instructor;
using ExaminationSystem.Helpers;
using ExaminationSystem.Models;
using ExaminationSystem.Repositories;

namespace ExaminationSystem.Services.Instructors
{
    public class InstructorService : IInstructorService
    {
        IRepository<Instructor> _repository;
        IMapper _mapper;

        public InstructorService(IRepository<Instructor> repository, IMapper mapper) 
        {
            _repository = repository;
            _mapper = mapper; 
        }
        public int AddInstructor(InstructorCreateDTO instructorCreateDTO)
        {
            Instructor instructor = _mapper.Map<Instructor>(instructorCreateDTO);
            Instructor instructorCreate = _repository.Add(instructor);
            _repository.SaveChanges();
            return instructor.ID;
        }

        public void Delete(int id)
        {
            Instructor instructor = _repository.GetWithTrackinByID(id);
            _repository.Delete(instructor);
            _repository.SaveChanges();
        }

        public IEnumerable<InstructorCreateDTO> GetAll()
        {
            IQueryable<Instructor> instructors = _repository.GetAll();
            return instructors.Map<InstructorCreateDTO>();
        }

        public InstructorCreateDTO GetById(int id)
        {
            Instructor instructor = _repository.GetByID(id);
            return _mapper.Map<InstructorCreateDTO>(instructor);
        }

        public int update(InstructorCreateDTO instructorCreateDTO)
        {
            Instructor instructor = _mapper.Map<Instructor>(instructorCreateDTO);
            _repository.Update(instructor);
            _repository.SaveChanges();
            return instructor.ID;
        }
    }
}
