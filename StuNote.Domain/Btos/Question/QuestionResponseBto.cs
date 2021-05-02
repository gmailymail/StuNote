namespace StuNote.Domain.Btos.Question
{
    public record QuestionResponseBto : BtoBase
    {
        public string StudentId { get; set; }

        public int SelectedAnswer { get; set; } = 0; //Zero based index, 0 is the first answer.

    }
}
