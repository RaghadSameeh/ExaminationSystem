using AutoMapper;
using ExaminationSystem.DTO.Course;
using ExaminationSystem.Helpers;
using ExaminationSystem.Models;
using ExaminationSystem.Repositories;
using ExaminationSystem.Services.Courses;

namespace ExaminationSystem.Services.Courses
{
    public class CourseService : ICourseService
    {
        IRepository<Course> _repository;
        IMapper _mapper;

        public CourseService(IRepository<Course> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
            
        }

        public int AddCourse(CourseCreateDTO courseDTO)
        {
            Course course = _mapper.Map<Course>(courseDTO);
            Course courseCreate = _repository.Add(course);
            _repository.SaveChanges();
            return course.ID;
        }

        public IEnumerable<CourseCreateDTO> GetAll()
        {
             IQueryable<Course> courses= _repository.GetAll();
            return courses.Map<CourseCreateDTO>();
        }

        public CourseCreateDTO GetById(int id)
        {
            Course course= _repository.GetByID(id);
            return _mapper.Map<CourseCreateDTO>(course);
        }

        public void Delete(int id)
        {
            Course course = _repository.GetWithTrackinByID(id);
            _repository.Delete(course);
            _repository.SaveChanges();

        }

        public int update (CourseCreateDTO courseCreateDTO)
        {
            Course course = _mapper.Map<Course>(courseCreateDTO);
            _repository.Update(course);
            _repository.SaveChanges();
            return course.ID;
       }
    }
}
