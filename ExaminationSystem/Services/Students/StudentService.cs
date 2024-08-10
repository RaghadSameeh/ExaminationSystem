using AutoMapper;
using ExaminationSystem.DTO.Student;
using ExaminationSystem.DTO.Student;
using ExaminationSystem.Helpers;
using ExaminationSystem.Models;
using ExaminationSystem.Repositories;

namespace ExaminationSystem.Services.Students
{
    public class StudentService : IStudentService
    {
        IRepository<Student> _repository;
        IMapper _mapper;

        public StudentService(IRepository<Student> repository, IMapper mapper) 
        { 
            _repository = repository;
            _mapper = mapper;
        }
        public int AddStudent(StudentCreateDto studentCreateDto)
        {
            Student student = _mapper.Map<Student>(studentCreateDto);
            Student studentCreate = _repository.Add(student);
            _repository.SaveChanges();
            return student.ID;
        }

        public void Delete(int id)
        {

            Student student = _repository.GetWithTrackinByID(id);
            _repository.Delete(student);
            _repository.SaveChanges();
        }

        public IEnumerable<StudentCreateDto> GetAll()
        {
            IQueryable<Student> students = _repository.GetAll();
            return students.Map<StudentCreateDto>();
        }

        public StudentCreateDto GetById(int id)
        {
            Student student = _repository.GetByID(id);
            return _mapper.Map<StudentCreateDto>(student);
        }

        public int update(StudentCreateDto studentCreateDto)
        {
            Student student = _mapper.Map<Student>(studentCreateDto);
            _repository.Update(student);
            _repository.SaveChanges();
            return student.ID;
        }
    }
}
