using Microsoft.Extensions.Logging;
using StuNote.Domain.Btos.Survey;
using StuNote.Domain.Services;
using System;
using System.Threading.Tasks;

namespace StuNote.Logic.Course
{
    public class DummySurveyRequestService : ISurveyRequestService
    {
        private readonly ILogger<DummySurveyRequestService> _logger;

        public DummySurveyRequestService(ILogger<DummySurveyRequestService> logger) => _logger = logger;

        public event EventHandler<SurveyResponseBto> ResponseReceived;

        public async Task<bool> SendAsync(SurveyRequestBto requestBto)
        {
            _logger.LogInformation("Survey request is sent!");
            await Task.CompletedTask;
            return true;
        }

        /// <summary>
        /// Use this method to raise test received event
        /// </summary>
        public async Task RasieReceivedEventAsync()
        {
            OnSurveyResponseReceived(new()
            {
                NoCount = 10,
                YesCount = 15
            });
            await Task.CompletedTask;
        }
        
        #region Helper Methods
        protected virtual void OnSurveyResponseReceived(SurveyResponseBto survey)
        {
            ResponseReceived?.Invoke(this, survey);
        }
        #endregion Helper Methods
    }
}
