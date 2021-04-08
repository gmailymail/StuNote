using StuNote.Domain.Btos.Survey;
using System;
using System.Threading.Tasks;

namespace StuNote.Domain.Services
{
    public interface ISurveyResponseService
    {
        event EventHandler<SurveyRequestBto> SurveyReceived;

        Task<bool> SendAsync(SurveyResponseBto responseBto);
    }
}
