using StuNote.Domain.Btos.Question;
using System;
using System.Threading.Tasks;

namespace StuNote.Domain.Services
{
    public interface IQuestionResponseService
    {
        event EventHandler<QuestionRequestBto> QuestionReceived;

        Task<bool> SendAsync(QuestionResponseBto responseBto);
    }
}
