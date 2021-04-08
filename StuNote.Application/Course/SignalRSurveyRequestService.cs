using Microsoft.Extensions.Logging;
using StuNote.Domain.Btos.Survey;
using StuNote.Domain.Services;
using System;
using System.Threading.Tasks;

namespace StuNote.Logic.Course
{
    public class SignalRSurveyRequestService : ISurveyRequestService
    {
        private readonly ILogger<DummySurveyRequestService> _logger;

        public SignalRSurveyRequestService(ILogger<DummySurveyRequestService> logger) => _logger = logger;

        public event EventHandler<SurveyResponseBto> ResponseReceived;

        public async Task<bool> SendAsync(SurveyRequestBto requestBto)
        {
            _logger.LogInformation("Call SignalR to send the Request");
            await Task.CompletedTask;
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
