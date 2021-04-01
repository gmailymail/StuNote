namespace StuNote.Domain.Btos.Contact
{
    public sealed record ContactBto : BtoBase
    {
        public string Cell { get; set; }
        public string Telephone { get; set; }
        public string EmergancyPhone { get; set; }
        public string PersonalEmail { get; set; }
        public string AlternateEmail { get; set; }
        public string WorkEmail { get; set; }

    }
}
