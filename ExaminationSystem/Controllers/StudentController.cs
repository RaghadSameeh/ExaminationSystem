using ExaminationSystem.DTO.Instructor;
using ExaminationSystem.Services.Instructors;
using ExaminationSystem.ViewModels.StudentViewModels;
using ExaminationSystem.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ExaminationSystem.Services.Students;
using ExaminationSystem.DTO.Student;
using ExaminationSystem.Helpers;

namespace ExaminationSystem.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        IStudentService studentService;
        public StudentController(IStudentService studentService)
        {
            this.studentService = studentService;  
        }

        [HttpPost]
        public ResultViewModel<int?> AddStudent(StudentViewModel StudentViewModel)
        {
            ResultViewModel<int?> result = new ResultViewModel<int?>();
            StudentCreateDto studentCreateDTO = StudentViewModel.MapOne<StudentCreateDto>();
            int id = studentService.AddStudent(studentCreateDTO);
            return new ResultViewModel<int?>()
            {
                Data = id,
                IsSuccess = true
            };

        }
        [HttpGet]
        public ResultViewModel<IEnumerable<StudentViewModel>> GetAll()
        {
            var students = studentService.GetAll()
                .Select(x => x.MapOne<StudentViewModel>());

            return new ResultViewModel<IEnumerable<StudentViewModel>>
            {
                IsSuccess = true,
                Data = students
            };
        }

        [HttpGet]
        public ResultViewModel<StudentViewModel> GetByID(int id)
        {
            var StudentViewModel = studentService.GetById(id).MapOne<StudentViewModel>();
            return new ResultViewModel<StudentViewModel>()
            {
                Data = StudentViewModel,
                IsSuccess = true
            };
        }

        [HttpDelete]
        public ResultViewModel<int> DeleteStudent(int id)
        {
            studentService.Delete(id);
            return new ResultViewModel<int>()
            {
                Data = id,
                IsSuccess = true
            };
        }

        [HttpPut]
        public ResultViewModel<int> UpdateStudent(StudentViewModel StudentViewModel)
        {
            ResultViewModel<int?> result = new ResultViewModel<int?>();
            StudentCreateDto studentCreateDTO = StudentViewModel.MapOne<StudentCreateDto>();
            int id = studentService.update(studentCreateDTO);
            return new ResultViewModel<int>()
            {
                Data = id,
                IsSuccess = true
            };


        }
    }
}

