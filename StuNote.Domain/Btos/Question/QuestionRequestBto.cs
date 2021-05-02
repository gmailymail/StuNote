namespace StuNote.Domain.Btos.Question
{
    public sealed record QuestionRequestBto : BtoBase
    {
        public string Question { get; set; }

        public string Answer1 { get; set; }

        public string Answer2 { get; set; }

        public string Answer3 { get; set; }

        public string Answer4 { get; set; }

        /// <summary>
        /// Zero based index, 0 is the first answer.
        /// </summary>
        public int CorrectAnswer { get; set; } = 0;
    }
}
