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

        public async Task<bool> SendAsync(SurveyResponseBto responseBto)
        {
            await _hub.Invoke("SendSurveyResponse", responseBto);
            return true;
        }

        #region Helper Methods

        private void OnSurveyReceived(SurveyRequestBto requestBto) => SurveyReceived?.Invoke(this, requestBto);

        #endregion Helper Methods
    }
}
