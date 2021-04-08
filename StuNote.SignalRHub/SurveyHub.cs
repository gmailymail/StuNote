using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;
using StuNote.Domain.Btos.Survey;

namespace StuNote.SignalRHub
{
    [HubName("StuNoteHub")]
    public class StuNoteHub : Hub
    {
        /// <summary>
        /// Teacher uses this method to send survey to all students.
        /// </summary>
        /// <param name="requestBto"></param>
        public void SendSurvey(SurveyRequestBto requestBto)
        {
            //Student App constantly monitory for this method for any surveys
            Clients.All.publishSurvey(requestBto);
        }

        /// <summary>
        /// Students uses this method to respond to survey requests
        /// </summary>
        /// <param name="responseBto"></param>
        public void SendSurveyResponse(SurveyResponseBto responseBto)
        {
            //Teacher App constantly monitory for this method for all the survey answers
            Clients.All.publishSurveyAnswer(responseBto);
        }
    }
}