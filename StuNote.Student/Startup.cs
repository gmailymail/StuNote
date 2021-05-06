using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using StuNote.Domain.Services;
using StuNote.Domain.Services.Infrastructure;
using StuNote.Infrastructure;
using StuNote.Infrastructure.Storage;
using StuNote.Logic.Course;
using StuNote.Logic.Question;
using StuNote.Logic.Survey;
using StuNote.Student.Services;
using StuNote.Student.UIControl;

namespace StuNote.Student
{
    public class Startup
    {
        public static void ConfigureServices(IServiceCollection services)
        {
            services.AddLogging(configure =>
            {
                configure.SetMinimumLevel(LogLevel.Debug);
                configure.AddConsole();
                configure.AddDebug();
            });
            
            //Add WinForms to the service
            RegisterForms(services);

            //Add Infrastructure services
            RegisterInfrastructureServices(services);

            //Add Business services
            RegisterBusinessServices(services);
        }

        /// <summary>
        /// Register all the Forms here
        /// </summary>
        /// <param name="services"></param>
        private static void RegisterForms(IServiceCollection services)
        {
            services.AddSingleton<FMain1>();
            services.AddScoped<FormSurveyAnswer>();
            services.AddScoped<FormQuestionAnswer>();
            services.AddSingleton<FormWindowSelector>();
        }

        /// <summary>
        /// Register all services related to infrastructure here
        /// </summary>
        /// <param name="services"></param>
        private static void RegisterInfrastructureServices(IServiceCollection services)
        {
            services.AddScoped<AzureStorageService>();
            services.AddScoped<LocalFileStorageService>();
            services.AddScoped<IStorageService, LocalFileStorageService>(s=>s.GetRequiredService<LocalFileStorageService>());
            services.AddScoped<IStorageService, AzureStorageService>(s => s.GetRequiredService<AzureStorageService>());
            services.AddScoped<IStorageLocatorFactoryService, StorageLocatorFactoryService>();
            services.AddScoped<IScreenSelectorService, ScreenSelectorService>();
            services.AddScoped<ICaptureScreenService, CaptureScreenService>();
            services.AddScoped<IImageToTextService, ImageToTextService>();
        }

        /// <summary>
        /// Register all services related to Business
        /// </summary>
        /// <param name="services"></param>
        private static void RegisterBusinessServices(IServiceCollection services)
        {
            services.AddScoped<ICourseService, DummyCourseService>();
            services.AddSingleton<ISurveyResponseService, SignalRSurveyResponseService>();
            services.AddSingleton<IQuestionResponseService, SignalRQuestionResponseService>();
            services.AddSingleton<ISignInService, SignInService>();
        }
    }

}
