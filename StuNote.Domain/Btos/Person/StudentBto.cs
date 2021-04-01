using System;

namespace StuNote.Domain.Btos.Person
{
    /// <summary>
    /// StudentBto represents the Students.
    /// NOTE : StudentBto Inherits from PersonBto Class
    /// </summary>
    public sealed record StudentBto : PersonBto
    {
        public DateTime DateOfBirth { get; set; }
    }
}
