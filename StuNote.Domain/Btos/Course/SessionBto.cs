using System;

namespace StuNote.Domain.Btos.Course
{
    /// <summary>
    /// Record for Sessions
    /// e.g : Session 04 of the TSD
    /// </summary>
    public sealed record SessionBto() : CourseBtoBase
    {
        public DateTime Date { get; set; }
    }

}
