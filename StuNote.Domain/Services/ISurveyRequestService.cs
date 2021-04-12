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
        /// <summary>
        /// Publish Surveys to students.
        /// </summary>
        /// <param name="requestBto"></param>
        /// <returns></returns>
        Task<bool> SendAsync(SurveyRequestBto requestBto);

        /// <summary>
        /// Event is triggerd when students respond to survey.
        /// </summary>
        event EventHandler<SurveyResponseBto> ResponseReceived;
    }
}
