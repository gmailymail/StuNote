using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;
using StuNote.Domain.Btos.Survey;

namespace StuNote.SignalRHub
{
    [HubName("StuNoteHub")]
    public class SurveyHub : Hub
    {
        public void SendSurvey(SurveyRequestBto requestBto)
        {
            Clients.All.publishSurvey(requestBto);
        }
    }
}