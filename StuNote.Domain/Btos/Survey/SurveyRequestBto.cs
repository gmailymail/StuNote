using System;

namespace StuNote.Domain.Btos.Survey
{
    public class SurveyRequestBto : EventArgs
    {
        /// <summary>
        /// For demo purposes Only Yes/No questions are supported
        /// </summary>
        public string Question { get; set; }

        public string Answer1 { get; set; }

        public string Answer2 { get; set; }
    }
}
