using System;

namespace StuNote.Domain.Btos.Survey
{
    public class SurveyResponseBto : EventArgs
    {
        public int YesCount { get; set; }

        public int NoCount { get; set; }

    }
}
