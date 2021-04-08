using StuNote.Domain.Btos.Survey;
using System;
using System.Threading.Tasks;

namespace StuNote.Domain.Services
{
    /// <summary>
    /// Responsible for Sending and Receiving Survey Responses
    /// from Teacher App
    /// </summary>
    public interface ISurveyRequestService
    {
        Task<bool> SendAsync(SurveyRequestBto requestBto);

        event EventHandler<SurveyResponseBto> ResponseReceived;
    }
}
