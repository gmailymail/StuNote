using Microsoft.AspNet.SignalR.Client;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using StuNote.Domain.Btos.Survey;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace StuNote.Student
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            //Prepare Host Container
            var host = Host.CreateDefaultBuilder()
                //Configure appsettings.json Application Settings 
                .ConfigureAppConfiguration((context, builder) =>
                {
                    builder.AddJsonFile("appsettings.json");
                })
                //Configure Domain and Infrastructure services
                .ConfigureServices((s,e)=>
                {
                    //Register all the services
                    Startup.ConfigureServices(e);

                    //Configure and Register SignalR
                    RegisterSignalRServices(s.Configuration, e);
                });

            //Build the host container
            var builderDefault = host.Build();

            //Build the servicer Provider
            using var serviceScop = builderDefault.Services.CreateScope();
            
            //Setup the service container
            var services = serviceScop.ServiceProvider;

            //Get FMain     
            FMain fMain = services.GetRequiredService<FMain>();

            Application.Run(fMain);            
        }

        /// <summary>
        /// Register SignalR to send and receive messages from the server.
        /// </summary>
        /// <param name="configuration"></param>
        /// <param name="services"></param>
        /// <returns></returns>
        private static void RegisterSignalRServices(
            IConfiguration configuration, 
            IServiceCollection services)
        {
            IHubProxy hub;
            string signalRServer = configuration.GetValue<string>("SignalRServer");
            string hubName = configuration.GetValue<string>("SignalRHubName");
            HubConnection connection = new(signalRServer);
            hub = connection.CreateHubProxy(hubName);
            services.AddScoped(s => hub);
            connection.Start().Wait();
        }
    }
}