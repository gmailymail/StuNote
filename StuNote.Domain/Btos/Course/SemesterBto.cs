using System.Collections.Generic;

namespace StuNote.Domain.Btos.Course
{
    /// <summary>
    /// Record for Semester
    /// e.g : Semester 01 of the MSC IT
    /// </summary>
    public sealed record SemesterBto : CourseBtoBase
    {
        public SemesterBto() => Modules= new List<ModuleBto>();

        public string Name { get; set; }

        /// <summary>
        /// A semester can contain one more Modules
        /// </summary>
        public IEnumerable<ModuleBto> Modules { get; set; }
    }
}
