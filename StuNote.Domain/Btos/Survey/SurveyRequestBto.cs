namespace StuNote.Domain.Btos.Survey
{
    public record SurveyRequestBto : BtoBase
    {
        /// <summary>
        /// For demo purposes Only Yes/No questions are supported
        /// </summary>
        public string Question { get; set; }

    }
}
