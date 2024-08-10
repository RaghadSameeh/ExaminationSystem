using AutoMapper;
using ExaminationSystem.DTO.Choice;
using ExaminationSystem.DTO.Course;
using ExaminationSystem.DTO.Exam;
using ExaminationSystem.DTO.ExamQuestion;
using ExaminationSystem.DTO.Instructor;
using ExaminationSystem.DTO.Question;
using ExaminationSystem.DTO.Result;
using ExaminationSystem.DTO.Student;
using ExaminationSystem.DTO.StudentAnswers;
using ExaminationSystem.DTO.StudentCourse;
using ExaminationSystem.DTO.StudentExam;
using ExaminationSystem.Models;
using ExaminationSystem.ViewModels.ChoiceViewModels;
using ExaminationSystem.ViewModels.CourseViewModels;
using ExaminationSystem.ViewModels.ExamViewModels;
using ExaminationSystem.ViewModels.InstructorViewModels;
using ExaminationSystem.ViewModels.QuestionViewModels;
using ExaminationSystem.ViewModels.StudentViewModels;

namespace ExaminationSystem.Profiles
{
    public class Profiles : Profile
    {
        public Profiles()
        {
            CreateMap<Course, CourseCreateDTO>();
            CreateMap<CourseCreateDTO, Course>();
            CreateMap<courseViewModel,CourseCreateDTO>().ReverseMap();

            CreateMap<Instructor, InstructorCreateDTO>();
            CreateMap<InstructorCreateDTO, Instructor>();
            CreateMap<InstructorViewModel,InstructorCreateDTO>().ReverseMap();

            CreateMap<Student, StudentCreateDto>();
            CreateMap<StudentCreateDto, Student>();
            CreateMap<StudentViewModel, StudentCreateDto>().ReverseMap();

            CreateMap<Question, QuestionCreateDTO>();
            CreateMap<QuestionCreateDTO, Question>();
            CreateMap<QuestionViewModel, QuestionCreateDTO>().ReverseMap();


            CreateMap<Choice,ChoiceCreateDTO>();
            CreateMap<ChoiceCreateDTO, Choice>();
            CreateMap<ChoiceViewModel, ChoiceCreateDTO>().ReverseMap();



            CreateMap<Exam, ExamCreateDTO>();
            CreateMap<ExamCreateDTO, Exam>();
            CreateMap<ExamViewModel, ExamCreateDTO>().ReverseMap();

            CreateMap<ExamQuestion,ExamQuestionDTO>();
            CreateMap<Result,ResultCreateDTO>();
            CreateMap<StudentCourse,StudentCourseDTO>();
            CreateMap<StudentExam, StudentExamDTO>();
            CreateMap<StudentAnswers, StudentAnswersDTO>();



        }

    }
}
