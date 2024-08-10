using ExaminationSystem.DTO.Instructor;
using ExaminationSystem.Services.Questions;
using ExaminationSystem.ViewModels.QuestionViewModels;
using ExaminationSystem.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ExaminationSystem.DTO.Question;
using ExaminationSystem.Helpers;

namespace ExaminationSystem.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class QuestionController : ControllerBase
    {

        IQuestionService _questionService;
        public QuestionController(IQuestionService questionService)
        {
            _questionService = questionService;  
        }

        [HttpPost]
        public ResultViewModel<int?> AddQuestion(QuestionViewModel QuestionViewModel)
        {
            ResultViewModel<int?> result = new ResultViewModel<int?>();
            QuestionCreateDTO questionCreateDTO = QuestionViewModel.MapOne<QuestionCreateDTO>();
            int id = _questionService.AddQuestion(questionCreateDTO);
            return new ResultViewModel<int?>()
            {
                Data = id,
                IsSuccess = true
            };

        }
        [HttpGet]
        public ResultViewModel<IEnumerable<QuestionViewModel>> GetAll()
        {
            var instructors = _questionService.GetAll()
                .Select(x => x.MapOne<QuestionViewModel>());

            return new ResultViewModel<IEnumerable<QuestionViewModel>>
            {
                IsSuccess = true,
                Data = instructors
            };
        }

        [HttpGet]
        public ResultViewModel<QuestionViewModel> GetByID(int id)
        {
            var QuestionViewModel = _questionService.GetById(id).MapOne<QuestionViewModel>();
            return new ResultViewModel<QuestionViewModel>()
            {
                Data = QuestionViewModel,
                IsSuccess = true
            };
        }

        [HttpDelete]
        public ResultViewModel<int> DeleteQuestion(int id)
        {
            _questionService.Delete(id);
            return new ResultViewModel<int>()
            {
                Data = id,
                IsSuccess = true
            };
        }

        [HttpPut]
        public ResultViewModel<int> UpdateQuestion(QuestionViewModel QuestionViewModel)
        {
            ResultViewModel<int?> result = new ResultViewModel<int?>();
            QuestionCreateDTO questionCreateDTO = QuestionViewModel.MapOne<QuestionCreateDTO>();
            int id = _questionService.update(questionCreateDTO);
            return new ResultViewModel<int>()
            {
                Data = id,
                IsSuccess = true
            };


        }
    }
}
