using Autofac;
using ExaminationSystem.Data;
using ExaminationSystem.Repositories;
using ExaminationSystem.Services.Choices;
using ExaminationSystem.Services.Courses;
using ExaminationSystem.Services.Exams;
using ExaminationSystem.Services.Instructors;
using ExaminationSystem.Services.Questions;
using ExaminationSystem.Services.Students;


namespace ExaminationSystem
{
    public class AutoFacModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
           builder.RegisterType<Context>().InstancePerLifetimeScope();
            builder.RegisterGeneric(typeof(Repository<>)).As(typeof(IRepository<>)).InstancePerLifetimeScope();
            builder.RegisterAssemblyTypes(typeof(ICourseService).Assembly).AsImplementedInterfaces().InstancePerLifetimeScope();
            builder.RegisterAssemblyTypes(typeof(IInstructorService).Assembly).AsImplementedInterfaces().InstancePerLifetimeScope();
            builder.RegisterAssemblyTypes(typeof(IStudentService).Assembly).AsImplementedInterfaces().InstancePerLifetimeScope();
            builder.RegisterAssemblyTypes(typeof(IQuestionService).Assembly).AsImplementedInterfaces().InstancePerLifetimeScope();
            builder.RegisterAssemblyTypes(typeof(IChoiceService).Assembly).AsImplementedInterfaces().InstancePerLifetimeScope();
            builder.RegisterAssemblyTypes(typeof(IExamService).Assembly).AsImplementedInterfaces().InstancePerLifetimeScope();







        }

    }
}
