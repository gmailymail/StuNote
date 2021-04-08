using Microsoft.AspNet.SignalR.Client;
using Microsoft.Extensions.Logging;
using StuNote.Domain.Btos.Survey;
using StuNote.Domain.Services;
using System;
using System.Threading.Tasks;

namespace StuNote.Logic.Survey
{
    public class SignalRSurveyResponseService : ISurveyResponseService
    {
        private readonly ILogger<SignalRSurveyResponseService> _logger;
        private readonly IHubProxy _hub;

        public SignalRSurveyResponseService(
            ILogger<SignalRSurveyResponseService> logger,
            IHubProxy hub)
        {
            _logger = logger;
            _hub = hub;
            _hub.On<SurveyRequestBto>("publishSurvey", (survey) => OnSurveyReceived(survey));
        }

        public event EventHandler<SurveyRequestBto> SurveyReceived;

        public Task<bool> SendAsync(SurveyResponseBto responseBto)
        {
            throw new NotImplementedException();
        }

        private void OnSurveyReceived(SurveyRequestBto requestBto)
        {
            SurveyRequestBto bto = new()
            {
                Question = requestBto.Question,
                Answer1 = requestBto.Answer1,
                Answer2 = requestBto.Answer2
            };
            SurveyReceived?.Invoke(this, bto);
        }
    }
}
