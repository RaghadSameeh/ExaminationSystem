using ExaminationSystem.DTO.Course;
using ExaminationSystem.Helpers;
using ExaminationSystem.Models;
using ExaminationSystem.Services.Courses;
using ExaminationSystem.ViewModels;
using ExaminationSystem.ViewModels.CourseViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExaminationSystem.Controllers
{
    [Route("api/[controller]/[Action]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        ICourseService _courseService;
        public CourseController(ICourseService courseService)
        {
            this._courseService = courseService;
        }

        [HttpPost]
        public ResultViewModel<int?> AddCourse(courseViewModel courseViewModel)
        {
            ResultViewModel<int?> result = new ResultViewModel<int?>();
            if (ModelState.IsValid)
            {
                try
                {
                    CourseCreateDTO courseCreateDTO = courseViewModel.MapOne<CourseCreateDTO>();
                    int id = _courseService.AddCourse(courseCreateDTO);
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
        [HttpGet]
        public ResultViewModel<IEnumerable<courseViewModel>> GetAll()
        {
            var courses = _courseService.GetAll()
                .Select(x => x.MapOne<courseViewModel>());

            return new ResultViewModel<IEnumerable<courseViewModel>>
            {
                IsSuccess = true,
                Data = courses
            };
        }

        [HttpGet]
        public ResultViewModel<courseViewModel> GetByID(int id)
        {
            var courseViewModel = _courseService.GetById(id).MapOne<courseViewModel>();
            return new ResultViewModel<courseViewModel>()
            {
                Data = courseViewModel,
                IsSuccess = true
            };
        }

        [HttpDelete]
        public ResultViewModel<int> DeleteCourse(int id)
        {
            _courseService.Delete(id);
            return new ResultViewModel<int>()
            {
                Data = id,
                IsSuccess = true
            };
        }

        [HttpPut]
        public ResultViewModel<int?> UpdateCourse (courseViewModel courseViewModel)
        {
            ResultViewModel<int?> result = new ResultViewModel<int?>();
            if (ModelState.IsValid)
            {
                try
                {
                    CourseCreateDTO courseCreateDTO = courseViewModel.MapOne<CourseCreateDTO>();
                    int id = _courseService.update(courseCreateDTO);
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

