using Microsoft.AspNet.SignalR.Client;
using Microsoft.Extensions.Logging;
using StuNote.Domain.Btos.Question;
using StuNote.Domain.Btos.Survey;
using StuNote.Domain.Services;
using System;
using System.Threading.Tasks;

namespace StuNote.Logic.Teacher.Question
{
    public class SignalRQuestionRequestService : IQuestionRequestService
    {
        private readonly ILogger<SignalRQuestionRequestService> _logger;
        private readonly IHubProxy _hub;

        public SignalRQuestionRequestService(
            ILogger<SignalRQuestionRequestService> logger,
            IHubProxy hub)
        {
            _logger = logger;
            _hub = hub;
            _hub.On<QuestionResponseBto>("publishQuestionAnswer", (response) => OnAnswerReceived(response));
        }

        public event EventHandler<QuestionResponseBto> AnswerReceived;

        public async Task<bool> SendAsync(QuestionRequestBto requestBto)
        {
            _logger.LogInformation("Call SignalR to send the Question");
            await _hub.Invoke("SendQuestion", requestBto);
            return true;
        }

        #region Helper Methods

        protected virtual void OnAnswerReceived(QuestionResponseBto answer) => AnswerReceived?.Invoke(this, answer);

        #endregion Helper Methods
    }
}
