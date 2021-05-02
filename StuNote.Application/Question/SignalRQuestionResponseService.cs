using Microsoft.AspNet.SignalR.Client;
using Microsoft.Extensions.Logging;
using StuNote.Domain.Btos.Question;
using StuNote.Domain.Services;
using System;
using System.Threading.Tasks;

namespace StuNote.Logic.Question
{
    public class SignalRQuestionResponseService : IQuestionResponseService
    {
        public event EventHandler<QuestionRequestBto> QuestionReceived;
       
        private readonly ILogger<SignalRQuestionResponseService> _logger;
        private readonly IHubProxy _hub;

        public SignalRQuestionResponseService(
            ILogger<SignalRQuestionResponseService> logger,
            IHubProxy hub)
        {
            _logger = logger;
            _hub = hub;
            _hub.On<QuestionRequestBto>("publishQuestion", (survey) => OnQuestionReceived(survey));
        }

        public async Task<bool> SendAsync(QuestionResponseBto responseBto)
        {
            await _hub.Invoke("SendQuestionResponse", responseBto);
            return true;
        }

        #region Helper Methods

        private void OnQuestionReceived(QuestionRequestBto requestBto) => QuestionReceived?.Invoke(this, requestBto);

        #endregion Helper Methods
    }
}
