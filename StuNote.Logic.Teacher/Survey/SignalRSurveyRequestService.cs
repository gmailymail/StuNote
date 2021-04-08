using Microsoft.AspNet.SignalR.Client;
using Microsoft.Extensions.Logging;
using StuNote.Domain.Btos.Survey;
using StuNote.Domain.Services;
using System;
using System.Threading.Tasks;

namespace StuNote.Logic.Teacher.Survey
{
    public class SignalRSurveyRequestService : ISurveyRequestService
    {
        private readonly ILogger<SignalRSurveyRequestService> _logger;
        private readonly IHubProxy _hub;

        public SignalRSurveyRequestService(
            ILogger<SignalRSurveyRequestService> logger,
            IHubProxy hub)
        {
            _logger = logger;
            _hub = hub;
        }

        public event EventHandler<SurveyResponseBto> ResponseReceived;

        public async Task<bool> SendAsync(SurveyRequestBto requestBto)
        {
            _logger.LogInformation("Call SignalR to send the Request");
            await _hub.Invoke("SendSurvey", requestBto);
            return true;
        }
        
        #region Helper Methods
        protected virtual void OnSurveyResponseReceived(SurveyResponseBto survey)
        {
            ResponseReceived?.Invoke(this, survey);
        }
        #endregion Helper Methods
    }
}
