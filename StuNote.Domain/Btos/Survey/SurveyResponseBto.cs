using System;

namespace StuNote.Domain.Btos.Survey
{
    public class SurveyResponseBto : EventArgs
    {
        public string StudentId { get; set; }

        public string Answer { get; set; }
    }
}
