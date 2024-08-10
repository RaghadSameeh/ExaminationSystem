using ExaminationSystem.DTO.Course;
using ExaminationSystem.Services.Instructors;
using ExaminationSystem.ViewModels.CourseViewModels;
using ExaminationSystem.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ExaminationSystem.ViewModels.InstructorViewModels;
using ExaminationSystem.DTO.Instructor;
using ExaminationSystem.Helpers;

namespace ExaminationSystem.Controllers
{
    [Route("api/[controller]/[Action]")]
    [ApiController]
    public class InstructorController : ControllerBase
    {
        IInstructorService _instructorService;
        public InstructorController(IInstructorService instructorService)
        {
            _instructorService = instructorService;
        }

        [HttpPost]
        public ResultViewModel<int?> AddInstructor(InstructorViewModel InstructorViewModel)
        {
            ResultViewModel<int?> result = new ResultViewModel<int?>();
            if (ModelState.IsValid)
            {
                try
                {
                    InstructorCreateDTO instructorCreateDTO = InstructorViewModel.MapOne<InstructorCreateDTO>();
                    int id = _instructorService.AddInstructor(instructorCreateDTO);
                    result.Data = id;
                    result.IsSuccess = true;
                }
                catch (Exception ex)
                {
                    result.Data = null;
                    result.IsSuccess = false;
                }
            }
            else
            {
                result.Data = null;
                result.IsSuccess = false;
            }
          return result;

        }
        [HttpGet]
        public ResultViewModel<IEnumerable<InstructorViewModel>> GetAll()
        {
            var instructors = _instructorService.GetAll()
                .Select(x => x.MapOne<InstructorViewModel>());

            return new ResultViewModel<IEnumerable<InstructorViewModel>>
            {
                IsSuccess = true,
                Data = instructors
            };
        }

        [HttpGet]
        public ResultViewModel<InstructorViewModel> GetByID(int id)
        {
            var InstructorViewModel = _instructorService.GetById(id).MapOne<InstructorViewModel>();
            return new ResultViewModel<InstructorViewModel>()
            {
                Data = InstructorViewModel,
                IsSuccess = true
            };
        }

        [HttpDelete]
        public ResultViewModel<int> DeleteInstructor(int id)
        {
            _instructorService.Delete(id);
            return new ResultViewModel<int>()
            {
                Data = id,
                IsSuccess = true
            };
        }

        [HttpPut]
        public ResultViewModel<int?> UpdateInstructor(InstructorViewModel InstructorViewModel)
        {
            ResultViewModel<int?> result = new ResultViewModel<int?>();
            if (ModelState.IsValid)
            {
                try
                {
                    InstructorCreateDTO instructorCreateDTO = InstructorViewModel.MapOne<InstructorCreateDTO>();
                    int id = _instructorService.update(instructorCreateDTO);
                    result.Data = id;
                    result.IsSuccess = true;
                }
                catch (Exception ex) {
                    result.Data = null;
                    result.IsSuccess = false;
                }
            }
            else
            {
                result.Data = null;
                result.IsSuccess = false;
            }
            return result;


        }
    }
}
