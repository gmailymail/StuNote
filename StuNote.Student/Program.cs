using DevExpress.Pdf.Native.BouncyCastle.Asn1.X509;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
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

            var host = Host.CreateDefaultBuilder()
                .ConfigureAppConfiguration((context, builder) =>
                {
                    builder.AddJsonFile("appsettings.json");
                })
                .ConfigureServices((s,e)=>
                {
                    Startup.ConfigureServices(e);
                });

            var builderDefault = host.Build();

            //Build the servicer Provider
            using var serviceScop = builderDefault.Services.CreateScope();

            
            //Setup the service container
            var services = serviceScop.ServiceProvider;
            
            //Build the servicer Provider
            //using var serviceProvider = services.getre();

            //Get the Main 
            FMain fMain = services.GetRequiredService<FMain>();

            Application.Run(fMain);
        }
    }
}