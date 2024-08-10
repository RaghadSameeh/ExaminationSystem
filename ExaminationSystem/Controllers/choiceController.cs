using ExaminationSystem.DTO.Course;
using ExaminationSystem.Services.Choices;
using ExaminationSystem.Services.Courses;
using ExaminationSystem.ViewModels.CourseViewModels;
using ExaminationSystem.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ExaminationSystem.ViewModels.ChoiceViewModels;
using ExaminationSystem.DTO.Choice;
using ExaminationSystem.Helpers;

namespace ExaminationSystem.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class choiceController : ControllerBase
    {
        IChoiceService _choiceService;

        public choiceController(IChoiceService choiceService
)
        {
            _choiceService = choiceService;
        }

        [HttpPost]
        public ResultViewModel<int?> AddChoice(ChoiceViewModel choiceViewModel)
        {
            ResultViewModel<int?> result = new ResultViewModel<int?>();
            if (ModelState.IsValid)
            {
                try
                {
                    ChoiceCreateDTO choiceCreateDTO = choiceViewModel.MapOne<ChoiceCreateDTO>();
                    int id = _choiceService.AddChoice(choiceCreateDTO);
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
        public ResultViewModel<IEnumerable<ChoiceViewModel>> GetAll()
        {
            var choices = _choiceService.GetAll()
                .Select(x => x.MapOne<ChoiceViewModel>());

            return new ResultViewModel<IEnumerable<ChoiceViewModel>>
            {
                IsSuccess = true,
                Data = choices
            };
        }

        [HttpGet]
        public ResultViewModel<ChoiceViewModel> GetByID(int id)
        {
            var choiceViewModel = _choiceService.GetById(id).MapOne<ChoiceViewModel>();
            return new ResultViewModel<ChoiceViewModel>()
            {
                Data = choiceViewModel,
                IsSuccess = true
            };
        }

        [HttpDelete]
        public ResultViewModel<int> DeleteChoice(int id)
        {
            _choiceService.Delete(id);
            return new ResultViewModel<int>()
            {
                Data = id,
                IsSuccess = true
            };
        }

        [HttpPut]
        public ResultViewModel<int?> UpdateChoice(ChoiceViewModel choiceViewModel)
        {
            ResultViewModel<int?> result = new ResultViewModel<int?>();
            if (ModelState.IsValid)
            {
                try
                {
                    ChoiceCreateDTO choiceCreateDTO = choiceViewModel.MapOne<ChoiceCreateDTO>();
                    int id = _choiceService.update(choiceCreateDTO);
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

    }
}

