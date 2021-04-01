namespace StuNote.Domain.Btos
{
    public abstract record BtoBase
    {
        /// <summary>
        /// Every Entity/Object StuNote has an
        /// internal number to uniquely recognize it.
        /// This number is captured in Id field.
        /// </summary>
        public int Id { get; set; }
    }
}
