using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using StuNote.Domain.Services;
using StuNote.Infrastructure;
using StuNote.Logic.Teacher.Survey;
using StuNote.Teacher.UIControl;

namespace StuNote.Teacher
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
            services.AddScoped<FMain>();
            services.AddScoped<UControlCreateSurvey>();
        }

        /// <summary>
        /// Register all services related to infrastructure here
        /// </summary>
        /// <param name="services"></param>
        private static void RegisterInfrastructureServices(IServiceCollection services)
        {
            //services.AddScoped<AzureStorageService>();
            //services.AddScoped<LocalFileStorageService>();
            //services.AddScoped<IStorageService, LocalFileStorageService>(s=>s.GetRequiredService<LocalFileStorageService>());
            //services.AddScoped<IStorageService, AzureStorageService>(s => s.GetRequiredService<AzureStorageService>());
            //services.AddScoped<IStorageLocatorFactoryService, StorageLocatorFactoryService>();
        }

        /// <summary>
        /// Register all services related to Business
        /// </summary>
        /// <param name="services"></param>
        private static void RegisterBusinessServices(IServiceCollection services)
        {
            services.AddScoped<ISurveyRequestService, SignalRSurveyRequestService>();
            services.AddSingleton<ISignInService, SignInService>();
        }
    }

}
