using StuNote.Domain.Btos.Question;
using System;
using System.Threading.Tasks;

namespace StuNote.Domain.Services
{
    /// <summary>
    /// Responsible for Sending and Receiving Questions and Answers
    /// from Teacher App
    /// </summary>
    public interface IQuestionRequestService
    {
        /// <summary>
        /// Publish Questions to students.
        /// </summary>
        /// <param name="requestBto"></param>
        /// <returns></returns>
        Task<bool> SendAsync(QuestionRequestBto requestBto);

        /// <summary>
        /// Event is triggerd when students respond to Questions.
        /// </summary>
        event EventHandler<QuestionResponseBto> AnswerReceived;
    }
}
