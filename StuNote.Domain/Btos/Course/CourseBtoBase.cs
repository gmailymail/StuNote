namespace StuNote.Domain.Btos.Course
{
    public abstract record CourseBtoBase : BtoBase
    {
        public string Number { get; set; }
    }
}
