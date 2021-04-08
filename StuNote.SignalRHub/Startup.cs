using Owin;
using Microsoft.Owin;

[assembly: OwinStartup(typeof(StuNote.SignalRHub.Startup))]
namespace StuNote.SignalRHub
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // Any connection or hub wire up and configuration should go here
            app.MapSignalR();
        }
    }
}